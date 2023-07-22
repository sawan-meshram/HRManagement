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
    public class DeleteDepartmentHandler : IHttpHandler
    {
 

        public bool IsReusable => true;

        public void ProcessRequest(HttpContext context)
        {
            String id = context.Request.QueryString["id"];

            //Console.WriteLine("User Id :" + id);
            JObject res = new JObject();
            DBConnection dbConn = null;
            try
            {
                dbConn = new DBConnection.DBConnectionBuilder().BuildConnection();

                DepartmentDao dao = new DepartmentDaoImpl(dbConn.Connection);

                if (dao.Delete(Int32.Parse(id)))
                {
                    res["status"] = "success";
                    Console.WriteLine("Deleted successfully");
                }
                else
                {
                    res["status"] = "failed";
                }
            }catch(Exception e)
            {
                res["status"] = "error";
                Console.WriteLine(e);
            }
            finally
            {
                if (dbConn != null)
                    dbConn.Disconnect();
            }
            //Console.WriteLine(res.ToString());
            context.Response.Write(JsonConvert.SerializeObject(res));
        }
    }
}
