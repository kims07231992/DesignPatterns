using PG5_DP_Prototype.Companies.CardOffice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Prototype.Companies.CardOffice.Cards
{
    public class ITDepartmentCard : CompanyCard
    {
        public ITDepartmentCard()
        {
            this.Address = "16, Pangyoyeok-ro 192beon-gil, Bundang-gu, Seongnam-si, Gyeonggi-do, Republic of Korea";
            this.PhoneNumber = "031-5170-2233";
        }

        public override CompanyCard Clone()
        {
            return (CompanyCard)this.MemberwiseClone();
        }
    }
}
