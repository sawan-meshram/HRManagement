using System;
//using System.Web;
//using System.Web.UI;
//using Mono.Data.Sqlite;
using System.Collections.Generic;
//using System.Web.Services;

using HRManagement.Util;
using HRManagement.Models;
using HRManagement.DAO;
using HRManagement.DAOImpl;
namespace HRManagement.Views.Employee
{

    public partial class Departments : System.Web.UI.Page
    {
        protected IList<Department> departments = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            Console.WriteLine("On Page Load Method");
            DBConnection dbConn = new DBConnection.DBConnectionBuilder().BuildConnection();


            DepartmentDao dao = new DepartmentDaoImpl(dbConn.Connection);

            departments = dao.ReadAll();
            Console.WriteLine("Total Dept found ::"+departments.Count);
            foreach(var dept  in departments)
            {
                Console.WriteLine("Id :{0} and Name : {1}", dept.Id, dept.Name);
            }

            dbConn.Disconnect();

        }
        /*
        protected void AddDepartmentSubmit(object sender, EventArgs args)
        {

            Console.WriteLine("Add Department Form");

            string name = Request.Form["departmentName"];
            Console.WriteLine("departmentName :" + name);

            name = U.ToTitleCase(name);


            //ool inserted = false;

            DBConnection dbConn = new DBConnection.DBConnectionBuilder().BuildConnection();

            //SqliteConnection conn = DBConnection.GetConnection(Path.DATABASE_PATH);
            //conn.Open();

            if (!DBTableChecker.IsTableExists(HRManagementTable.DEPARTMENT.ToString(), dbConn.Connection))
            {
                DBTableQuery.CreateTable(HRManagementTable.DEPARTMENT, dbConn.Connection);
            }

            DepartmentDao dao = new DepartmentDaoImpl(dbConn.Connection);
            if(dao.Insert(new Department() { Name = name }))
            {
                //inserted = true;
                Console.WriteLine("Add Department Form");
            }

            dbConn.Disconnect();

        }

        [WebMethod]
        public static string AddDepartment(string departmentName)
        {
            try
            {
                Console.WriteLine("Add Department Form");
                Console.WriteLine("departmentName :" + departmentName);

                departmentName = U.ToTitleCase(departmentName);

                DBConnection dbConn = new DBConnection.DBConnectionBuilder().BuildConnection();

                if (!DBTableChecker.IsTableExists(HRManagementTable.DEPARTMENT.ToString(), dbConn.Connection))
                {
                    DBTableQuery.CreateTable(HRManagementTable.DEPARTMENT, dbConn.Connection);
                }

                DepartmentDao dao = new DepartmentDaoImpl(dbConn.Connection);
                if (dao.Insert(new Department() { Name = departmentName }))
                {
                    Console.WriteLine("Add Department Form");
                }

                dbConn.Disconnect();
                return "success";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "failed";
            }
        }*/
    }
}
