using PG5_DP_Prototype.Companies.CardOffice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Prototype.Companies.CardOffice.Cards
{
    public abstract class CompanyCard
    {
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Position { get; set; } = "Employee";
        public string Name { get; set; } = "Dummy Name";

        public abstract CompanyCard Clone();

        public void Print()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", this.Address, this.PhoneNumber, this.Position, this.Name);
        }
    }
}
