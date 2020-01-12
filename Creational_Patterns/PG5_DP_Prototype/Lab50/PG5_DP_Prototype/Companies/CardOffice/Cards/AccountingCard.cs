using PG5_DP_Prototype.Companies.Branches.Departments.Emplolyees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Prototype.Companies.CardOffice.Cards
{
    public class AccountingCard : CompanyCard
    {
        public AccountingCard()
        {
            this.Address = "517, Teheran-ro, Gangnam-gu, Seoul, Republic of Korea";
            this.PhoneNumber = "02-2622-2233";
        }

        public override CompanyCard Clone()
        {
            return (CompanyCard)this.MemberwiseClone();
        }
    }
}
