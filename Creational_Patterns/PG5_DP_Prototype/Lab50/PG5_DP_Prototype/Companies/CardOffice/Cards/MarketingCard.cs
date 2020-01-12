using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Prototype.Companies.CardOffice.Cards
{
    public class MarketingCard : CompanyCard
    {
        public MarketingCard()
        {
            this.Address = "57, Centum dong-ro, Haeundae-gu, Busan, Republic of Korea";
            this.PhoneNumber = "051-745-2290";
        }

        public override CompanyCard Clone()
        {
            return (CompanyCard)this.MemberwiseClone();
        }
    }
}
