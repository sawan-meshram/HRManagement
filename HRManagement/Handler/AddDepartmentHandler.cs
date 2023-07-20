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
    public class AddDepartmentHandler : IHttpHandler
    {
        public bool IsReusable => false;

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
            try
            {
                Department dept = JsonConvert.DeserializeObject<Department>(jsonString);


                Console.WriteLine("Add Department Form");
                Console.WriteLine("departmentName :" + dept.Name);

                dept.Name = U.ToTitleCase(dept.Name);

                DBConnection dbConn = new DBConnection.DBConnectionBuilder().BuildConnection();

                if (!DBTableChecker.IsTableExists(HRManagementTable.DEPARTMENT.ToString(), dbConn.Connection))
                {
                    DBTableQuery.CreateTable(HRManagementTable.DEPARTMENT, dbConn.Connection);
                }

                dept.Name = U.ToTitleCase(dept.Name);

                DepartmentDao dao = new DepartmentDaoImpl(dbConn.Connection);

                bool inserted = false, dup = false;
                if (!dao.IsRecordExists(dept.Name))
                {
                    inserted = dao.Insert(dept);
                    Console.WriteLine("Inserted success");
                }
                else
                {
                    dup = true;
                }

                dbConn.Disconnect();
                context.Response.ContentType = "application/json";

                if (inserted)
                {
                    res["status"] = "success";

                    //JObject deptJson = new JObject();
                    //deptJson["Id"] = dept.Id;
                    //deptJson["Name"] = dept.Name;
                    res["result"] = JObject.FromObject(dept);

                    //res["result"] = JsonConvert.SerializeObject(dept);
                }
                else
                {
                    if(dup) res["status"] ="duplicate";
                    else res["status"] = "failed";
                }
                Console.WriteLine("result ::"+res.ToString());
                context.Response.Write(JsonConvert.SerializeObject(res));

            }
            catch (Exception e)
            {
                res["status"] ="failed";
                Console.WriteLine(e);
                context.Response.Write(JsonConvert.SerializeObject(res));
            }
        }
    }
}
