using PG5_DP_Command.TelecomCompany.Orders;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Command.TelecomCompany.Products
{
    public abstract class Product
    {
        public Product(int qty)
        {
            this.Quantity = qty;
        }

        public string Name { get; protected set; }
        public int Quantity { get; set; }
    }
}
