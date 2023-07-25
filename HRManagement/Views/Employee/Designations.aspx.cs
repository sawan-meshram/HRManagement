using System;
//using System.Web;
using System.Collections.Generic;

using HRManagement.Util;
using HRManagement.Models;
using HRManagement.DAO;
using HRManagement.DAOImpl;
namespace HRManagement.Views.Employee
{

    public partial class Designations : System.Web.UI.Page
    {
        protected IList<Department> departments = null;
        protected IList<Designation> designations = null;

        protected void Page_Load(object sender, EventArgs e)
        {

            Console.WriteLine("On Page Load Method");
            DBConnection dbConn = new DBConnection.DBConnectionBuilder().BuildConnection();

            departments = new DepartmentDaoImpl(dbConn.Connection).ReadAll();
            designations = new DesignationDaoImpl(dbConn.Connection).ReadAll();

            Console.WriteLine("Total Dept found ::" + designations.Count);
            foreach (var des in designations)
            {
                Console.WriteLine("Id :{0} and Name : {1} & DeptName :{2}", des.Id, des.Name, des.Department.Name);
            }

            dbConn.Disconnect();

        }
    }
}
