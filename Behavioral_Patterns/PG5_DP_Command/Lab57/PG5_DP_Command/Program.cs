using PG5_DP_Command.TelecomCompany.Orders;
using PG5_DP_Command.TelecomCompany.Products;
using PG5_DP_Command.TelecomCompany.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static PG5_DP_Command.TelecomCompany.Orders.Command;

namespace PG5_DP_Command
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            Product product = new KimchiFridge(100);
            Shipper shipper = new Shipper(); // closure
            int salesPeople = 10;
            int orderNum = 5; // 각 판매원이 담당하는 주문 횟수

            for (int i = 0; i < salesPeople; i++) // 10 명의 판매원이 판매 시작
            {
                new Thread((p) => 
                {
                    var pdt = p as Product;
                    var salesMan = new SalesMan();
                
                    for (int j = 0; j < orderNum; j++) // 각 판매원이 여러 주문 받음
                    {
                        int quantity = new Random().Next(0, 3); // 0 ~ 3 random integer
                        var order = new Order(shipper, pdt, "name", "address", "phone", quantity);
                        salesMan.PlaceOrder(order);
                    }
                    salesMan.ExecuteAll();
                }).Start(product);
            }

            int time = 1000 * 60 * 30; // 30min
            Thread.Sleep(time);         
        }        
    }
}
