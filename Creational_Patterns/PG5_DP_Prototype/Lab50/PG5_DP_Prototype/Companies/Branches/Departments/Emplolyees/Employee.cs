using PG5_DP_Prototype.Companies.CardOffice.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Prototype.Companies.Branches.Departments.Emplolyees
{
    public class Employee
    {
        public Employee(string name, Department department)
        {
            this.Name = name;
            this.Department = department;
            this.Key = this.Department.AddEmployee(this); // set key
        }
        private int Key { get; set; }
        private Department Department { get; set; }
        private Lazy<List<Employee>> Subordinates { get; set; } = new Lazy<List<Employee>>();
        public string Name { get; private set; }
        public string Position { get; set; } = "Employee";
        public CompanyCard CompanyCard { get; set; }

        public void AddEmployee(Employee employee)
        {
            this.Subordinates.Value.Add(employee);
        }
        public void RemoveEmployee(Employee employee)
        {
            this.Subordinates.Value.Remove(employee);
        }
    }
}
