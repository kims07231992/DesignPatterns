using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG5_DP_TemplMeth.Ecommerce.EcommerceHandlers
{
    public class EcommerceHandler
    {
        private Lazy<List<Order>> OrderList { get; set; } = new Lazy<List<Order>>();
        protected double TaxRate { get; set; }
        public int ProductQuantity { get; set; }

        public void MakeOrder(string productName, string customerName, 
            string customerAddress, int orderNumber, int orderQuantity)
        {
            var order = new Order(productName, customerName, 
                customerAddress, orderNumber, orderQuantity);

            RegisterOrder(order); // Logic1 
            CheckOrderQuantity(order.OrderQuantity); // Logic2
            CheckCustomerAddress(order.CustomerAddress); // Logic3
            var calculatedTotalPrice = CaculateTax(order.TotalPrice); // Logic4
            order.TotalPrice = calculatedTotalPrice;    
            CheckOutWithCreditCard(order.TotalPrice); // Logic5
        }

        private void RegisterOrder(Order order)
        {
            this.OrderList.Value.Add(order);
        }

        private void CheckOrderQuantity(int orderQuantity)
        {
            if (this.ProductQuantity < orderQuantity)
            {
                throw new ArgumentException(
                    "Exceeded Order Quantity.", nameof(orderQuantity));
            }
        }

        private void CheckOutWithCreditCard(decimal totalPrice)
        {
            // Check out with the credit card.
        }

        protected virtual void CheckCustomerAddress(string customerAddress)
        {
            // do something
        }

        protected virtual decimal CaculateTax(decimal totalPrice)
        {
            var tax = Convert.ToDecimal(1 + this.TaxRate);            
            return totalPrice *= tax;
        }
    }
}
