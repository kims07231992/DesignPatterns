using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Command.TelecomCompany.Products
{
    public class KimchiFridge : Product
    {
        public KimchiFridge(int qty) : base(qty)
        {
            this.Name = "Kimchi_Fridge";
        }
    }
}
