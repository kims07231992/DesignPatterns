using PG5_DP_Prototype.Companies.Branches.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Prototype.Companies.Branches
{
    public class Branch
    {
        public Branch(string name, Company company)
        {
            this.Name = name;
            this.Company = company;
            this.Key = this.Company.AddBranch(this); // set key
        }

        private int Key { get; set; }
        private Company Company { get; set; }
        private Lazy<SortedDictionary<int, Department>> Departments { get; set; } = new Lazy<SortedDictionary<int, Department>>(); // key & Department
        public string Name { get; private set; }
        public string PhoneNumber { get; set; } = string.Empty;

        public int AddDepartment(Department department) // to avoid access like public get() with .Remove()
        {
            int key = this.Departments.Value.Count + 1;
            this.Departments.Value.Add(key, department); // add with increased key

            return key;
        }
    }
}
