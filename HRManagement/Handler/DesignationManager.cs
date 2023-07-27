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
    public class DesignationManager : IHttpHandler
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

                Designation designation = JsonConvert.DeserializeObject<Designation>(jsonString);

                dbConn = new DBConnection.DBConnectionBuilder().BuildConnection();
                DesignationDao dao = new DesignationDaoImpl(dbConn.Connection);


                if (queryType.Equals("delete"))
                {
                    flag = dao.Delete(designation.Id);
                }
                else
                {
                    designation.Name = U.ToTitleCase(designation.Name);

                    if (!dao.IsRecordExists(designation.Name, designation.Department.Id))
                    {
                        if (queryType.Equals("create"))
                        {
                            flag = dao.Insert(designation);
                        }
                        else if (queryType.Equals("update"))
                        {
                            flag = dao.Update(designation);
                        }
                    }
                    else
                    {
                        dup = true;
                    }
                    if (flag)
                    {
                        res["result"] = JObject.FromObject(designation);
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
        }
    }
}
