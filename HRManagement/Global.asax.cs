using System;
using System.Web;
using System.Web.Routing;
using HRManagement.App_Start;

using HRManagement.Util;

namespace HRManagement
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            DBConnection dbConn = null;
            try
            {
                dbConn = new DBConnection.DBConnectionBuilder().BuildConnection();

                if (!DBTableChecker.IsTableExists(HRManagementTable.DEPARTMENT.ToString(), dbConn.Connection))
                {
                    DBTableQuery.CreateTable(HRManagementTable.DEPARTMENT, dbConn.Connection);
                }
                if (!DBTableChecker.IsTableExists(HRManagementTable.DESIGNATION.ToString(), dbConn.Connection))
                {
                    DBTableQuery.CreateTable(HRManagementTable.DESIGNATION, dbConn.Connection);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (dbConn != null)
                    dbConn.Disconnect();
            }
        }
        /*
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }*/

    }
}
