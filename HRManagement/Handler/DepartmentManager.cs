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
    public class DepartmentManager : IHttpHandler
    {
        public bool IsReusable => true;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";

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
                bool flag = false, dup = false;
                JObject jObject = JObject.Parse(jsonString);

                string queryType = (string)jObject["type"];
                string deptQuery = jObject["query"].ToString();
                //Console.WriteLine(string.Format("queryType : {0}, DeptQuery : {1}", queryType, deptQuery));

                Department department = JsonConvert.DeserializeObject<Department>(deptQuery);

                dbConn = new DBConnection.DBConnectionBuilder().BuildConnection();
                DepartmentDao dao = new DepartmentDaoImpl(dbConn.Connection);



                if (queryType.Equals("delete"))
                {
                    flag = dao.Delete(department.Id);
                }
                else
                {
                    department.Name = U.ToTitleCase(department.Name);

                    if (!dao.IsRecordExists(department.Name))
                    {
                        if (queryType.Equals("create"))
                        {
                            flag = dao.Insert(department);
                        }
                        else if (queryType.Equals("update"))
                        {
                            flag = dao.Update(department);
                        }
                    }
                    else
                    {
                        dup = true;
                    }
                    if (flag)
                    {
                        res["result"] = JObject.FromObject(department);
                    }
                }
                if (flag)
                {
                    res["status"] = "success";
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

        }//eof ProcessRequest()

    }
}
