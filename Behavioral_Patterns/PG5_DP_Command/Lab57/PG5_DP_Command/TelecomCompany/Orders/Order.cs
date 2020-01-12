using PG5_DP_Command.TelecomCompany.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Command.TelecomCompany.Orders
{
    public class Order : Command
    {
        public Order(Shipper shipper, Product product, string name, string address, string phone, int qty)
        {
            this.Shipper = shipper;
            this.Product = product;
            this.CustomerName = name;
            this.CustomerAddress = address;
            this.CustomerPhoneNumber = phone;
            this.Quantity = qty;
        }

        protected string CustomerName { get; set; }
        protected string CustomerAddress { get; set; }
        protected string CustomerPhoneNumber { get; set; }
        public Shipper Shipper { get; protected set; }
        public Product Product { get; protected set; }
        public int Quantity { get; set; }

        public override void Execute()
        {
            this.Shipper.ProgressOrder(this);
        }
    }
}
