using System;
using System.Web;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using HRManagement.Util;
using HRManagement.Models;
using HRManagement.DAO;
using HRManagement.DAOImpl;

namespace HRManagement.Handler
{
    public class AddDesignationHandler : IHttpHandler
    {
        public AddDesignationHandler()
        {
        }

        public bool IsReusable => true;

        public void ProcessRequest(HttpContext context)
        {
            Console.WriteLine("called handler");
            var jsonString = string.Empty;


            using (Stream inputStream = context.Request.InputStream)
            {
                using (StreamReader readStream = new StreamReader(inputStream, Encoding.UTF8))
                {
                    jsonString = readStream.ReadToEnd();
                }
            }

            Console.WriteLine("jsonString :" + jsonString);
            JObject res = new JObject();
            DBConnection dbConn = null;
            try
            {
                Designation designation = JsonConvert.DeserializeObject<Designation>(jsonString);


                Console.WriteLine("Add Department Form");
                Console.WriteLine("designationName :" + designation.Name);

                dbConn = new DBConnection.DBConnectionBuilder().BuildConnection();

                if (!DBTableChecker.IsTableExists(HRManagementTable.DESIGNATION.ToString(), dbConn.Connection))
                {
                    DBTableQuery.CreateTable(HRManagementTable.DESIGNATION, dbConn.Connection);
                }

                designation.Name = U.ToTitleCase(designation.Name);

                DesignationDao dao = new DesignationDaoImpl(dbConn.Connection);

                bool inserted = false, dup = false;
                if (!dao.IsRecordExists(designation.Name, designation.Department.Id))
                {
                    inserted = dao.Insert(designation);
                    Console.WriteLine("Inserted success");
                }
                else
                {
                    dup = true;
                }


                context.Response.ContentType = "application/json";

                if (inserted)
                {
                    res["status"] = "success";

                    //JObject deptJson = new JObject();
                    //deptJson["Id"] = dept.Id;
                    //deptJson["Name"] = dept.Name;
                    res["result"] = JObject.FromObject(designation);

                    //res["result"] = JsonConvert.SerializeObject(dept);
                }
                else
                {
                    if (dup) res["status"] = "duplicate";
                    else res["status"] = "failed";
                }
                Console.WriteLine("result ::" + res.ToString());
                //context.Response.Write(JsonConvert.SerializeObject(res));

            }
            catch (Exception e)
            {
                res["status"] = "error";
                Console.WriteLine(e);
                //context.Response.Write(JsonConvert.SerializeObject(res));
            }
            finally
            {
                if (dbConn != null)
                    dbConn.Disconnect();
            }
            context.Response.Write(JsonConvert.SerializeObject(res));
        }
    }
}
