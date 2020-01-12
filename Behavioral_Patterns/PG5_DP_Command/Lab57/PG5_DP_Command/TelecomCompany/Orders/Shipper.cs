using PG5_DP_Command.TelecomCompany.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_Command.TelecomCompany.Orders
{
    public class Shipper
    {
        private object _quantityLock = new object();

        public bool CheckQuantity(Product product, int orderQty)
        {
            lock (this._quantityLock)
            {
                if (product.Quantity >= orderQty)
                {
                    product.Quantity -= orderQty;
                    return true;
                }
                return false; // quantity < requested quantity
            }
        }

        public void ProgressOrder(Order order)
        {
            CheckOut(order);
            Ship(order);
        }

        private void CheckOut(Order order)
        {
            Console.WriteLine($"{order.Product.Name} has been checked out, ");
        }

        private void Ship(Order order)
        {   
            Console.WriteLine($"Your order has been shipped, {DateTime.Now}");
        }
    }
}
