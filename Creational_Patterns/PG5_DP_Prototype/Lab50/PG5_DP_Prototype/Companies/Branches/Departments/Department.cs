using PG5_DP_Prototype.Companies.Branches.Departments.Emplolyees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Prototype.Companies.Branches.Departments
{
    public class Department
    {
        public Department(string name, Branch branch)
        {
            this.Name = name;
            this.Branch = branch;
            this.Key = this.Branch.AddDepartment(this); // set key
        }

        private int Key { get; set; }
        private Branch Branch { get; set; }
        private Lazy<SortedDictionary<int, Employee>> Employees { get; set; } = new Lazy<SortedDictionary<int, Employee>>(); // key & Employee
        public string Name { get; private set; }
        public string Address { get; set; } = string.Empty;

        public int AddEmployee(Employee employee) // to avoid access like public get() with .Remove()
        {
            int key = this.Employees.Value.Count + 1;
            this.Employees.Value.Add(key, employee); // add with increased key

            return key;
        }
    }
}
