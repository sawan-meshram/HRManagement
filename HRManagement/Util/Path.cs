using System;
using System.Web;

namespace HRManagement.Util
{
    public class Path
    {
        public static readonly string DATA_SOURCE = HttpContext.Current.Server.MapPath("~/App_Data" );

        public static readonly string DATABASE_PATH = System.IO.Path.Combine(DATA_SOURCE, "Database", "hrmanage.db");

        public static readonly string EMPLOYEE_RESUME_PATH = System.IO.Path.Combine(DATA_SOURCE, "Employee_Resume");

        public static readonly string INTERVIEW_RESUME_PATH = System.IO.Path.Combine(DATA_SOURCE, "Interview_Resume");


    }
}
