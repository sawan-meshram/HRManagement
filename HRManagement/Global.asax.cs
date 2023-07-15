using System;
using System.Web;
using System.Web.Routing;
using HRManagement.App_Start;

namespace HRManagement
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        /*
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }*/

    }
}
