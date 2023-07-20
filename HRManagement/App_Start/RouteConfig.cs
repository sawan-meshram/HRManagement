using System;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;
namespace HRManagement.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            RouteValueDictionary routeDict = new RouteValueDictionary { { "anything", "dashboard|emplyoee|organization" } };

            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);
            routes.MapPageRoute("default", "", "~/Views/Login.aspx");
            routes.MapPageRoute("forgotpassword", "forgotpassword", "~/Views/ForgotPassword.aspx");
            routes.MapPageRoute("registration", "registration", "~/Views/Registration.aspx");
            routes.MapPageRoute("dashboard", "dashboard", "~/Views/Dashboard.aspx");
            //routes.MapPageRoute("employee-registration", "emplyoee/registration", "~/Views/EmployeeRegistration.aspx");

            //routes.MapPageRoute("employee-registration", "{anything}/emplyoee/registration", "~/Views/EmployeeRegistration.aspx", false, null, routeDict);
            //routes.MapPageRoute("employee-employees", "{anything}/emplyoee/employees", "~/Views/AllEmployee.aspx", false, null, routeDict);
            //routes.MapPageRoute("organization-departments", "{anything}/organization/departments", "~/Views/Departments.aspx", false, null, routeDict);
            //routes.MapPageRoute("organization-designations", "{anything}/organization/designations", "~/Views/Designations.aspx", false, null, routeDict);


            routes.MapPageRoute("employee-registration", "employee-registration", "~/Views/Employee/EmployeeRegistration.aspx");
            routes.MapPageRoute("employee-employees", "employee-employees", "~/Views/Employee/AllEmployee.aspx");
            routes.MapPageRoute("employee-departments", "employee-departments", "~/Views/Employee/Departments.aspx");
            routes.MapPageRoute("employee-designations", "employee-designations", "~/Views/Employee/Designations.aspx");

            routes.MapPageRoute("job-candidate-registration", "job-candidate-registration", "~/Views/Administration/CandidateRegistration.aspx");
            routes.MapPageRoute("job-candidates", "job-candidates", "~/Views/Administration/AllCandidate.aspx");
            routes.MapPageRoute("employee-add-attendance", "employee-add-attendance", "~/Views/Administration/AddAttendance.aspx");

        }
    }
}
