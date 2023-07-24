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
    public class UpdateDepartmentHandler : IHttpHandler
    {
        public bool IsReusable => true;

        public void ProcessRequest(HttpContext context)
        {
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
                Department dept = JsonConvert.DeserializeObject<Department>(jsonString);


                Console.WriteLine("Update Department");
                Console.WriteLine("new departmentName :" + dept.Name);

                dbConn = new DBConnection.DBConnectionBuilder().BuildConnection();

                dept.Name = U.ToTitleCase(dept.Name);

                DepartmentDao dao = new DepartmentDaoImpl(dbConn.Connection);

                bool updated = false, dup = false;
                if (!dao.IsRecordExists(dept.Name))
                {
                    updated = dao.Update(dept);
                    Console.WriteLine("Inserted success");
                }
                else
                {
                    dup = true;
                }


                context.Response.ContentType = "application/json";

                if (updated)
                {
                    res["status"] = "success";

                    res["result"] = JObject.FromObject(dept);
                }
                else
                {
                    if (dup) res["status"] = "duplicate";
                    else res["status"] = "failed";
                }
                Console.WriteLine("result ::" + res.ToString());

            }
            catch (Exception e)
            {
                res["status"] = "error";
                Console.WriteLine(e);
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
