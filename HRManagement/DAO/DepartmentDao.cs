using System;
using HRManagement.Models;
using System.Collections.Generic;
namespace HRManagement.DAO
{
    public interface DepartmentDao
    {
        IList<Department> ReadAll();
        Department Read(int id);
        bool Insert(Department department);
        bool Update(Department department);
        bool Delete(int id);
        bool IsRecordExists(string departmentName);
    }
}
