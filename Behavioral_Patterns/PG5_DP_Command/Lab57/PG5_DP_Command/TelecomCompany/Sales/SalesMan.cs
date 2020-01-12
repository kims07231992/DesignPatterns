using PG5_DP_Command.TelecomCompany.Orders;
using PG5_DP_Command.TelecomCompany.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Threading;

namespace PG5_DP_Command.TelecomCompany.Sales
{
    public class SalesMan
    {
        private Queue<Order> _orderQueue = new Queue<Order>();

        public void PlaceOrder(Order order)
        {
            var shipper = order.Shipper;

            if (shipper.CheckQuantity(order.Product, order.Quantity))
            {
                this._orderQueue.Enqueue(order);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(PlaceOrder));
            }
        }

        public void ExecuteAll()
        {
            int time = 1000 * 60 * 5; // 5 min

            foreach (var order in this._orderQueue)
            {
                order.Execute();
            }
            Thread.Sleep(time);
        }
    }
}
