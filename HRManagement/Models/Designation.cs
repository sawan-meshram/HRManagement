using System;
namespace HRManagement.Models
{
    public class Designation
    {
        public Designation()
        {
        }

        public Designation(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Designation(int id, string name, Department department)
        {
            Id = id;
            Name = name;
            Department = department;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }

        public override string ToString()
        {
            return $"Id : {Id}, Name : {Name}, Department : {Department}";
        }
    }
}
