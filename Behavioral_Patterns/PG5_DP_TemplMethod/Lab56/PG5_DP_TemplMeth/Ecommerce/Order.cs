using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_TemplMeth.Ecommerce
{
    public class Order
    {
        private static decimal PRICE = 100;

        public Order(string productName, string customerName, 
            string customerAddress, int orderNumber, int orderQuantity)
        {
            this.ProductName = productName;
            this.CustomerName = customerName;
            this.CustomerAddress = customerAddress;
            this.OrderNumber = orderNumber;
            this.OrderQuantity = orderQuantity;

            this.TotalPrice = PRICE * orderQuantity;
        }

        public string ProductName { get; private set; }
        public string CustomerName { get; private set; }
        public string CustomerAddress { get; private set; }
        public int OrderNumber { get; private set; }
        public int OrderQuantity { get; private set; }
        public decimal TotalPrice { get; set; }
    }
}
