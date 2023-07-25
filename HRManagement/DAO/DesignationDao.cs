using System;
using HRManagement.Models;
using System.Collections.Generic;
namespace HRManagement.DAO
{
    public interface DesignationDao
    {
        IList<Designation> ReadAll();
        Designation Read(int id);
        bool Insert(Designation designation);
        bool Update(Designation designation);
        bool Delete(int id);
        bool IsRecordExists(string designationName, int departmentId);
    }
}
