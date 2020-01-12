using PG5_DP_Prototype.Companies.Branches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Prototype.Companies
{
    public class Company
    {
        public Company(string name, string logo)
        {
            this.Name = name;
            this.Logo = logo;
        }

        private Lazy<SortedDictionary<int, Branch>> Branches { get; set; } = new Lazy<SortedDictionary<int, Branch>>(); // key & Branch
        public string Name { get; private set; }
        public string Logo { get; private set; }

        public int AddBranch(Branch branch) // to avoid access like public get() with .Remove()
        {
            int key = this.Branches.Value.Count + 1;
            this.Branches.Value.Add(key, branch); // add with increased key

            return key;
        }
    }
}
