using System;
using System.Linq;
using OrderLib;

namespace TheOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            Order o = new Order();

            var orders = Helper.makeOrders();

            var someOrder = from oi in orders
                select new
                {
                    OrderNo = oi.OrderId,
                    OrderDate = oi.OrderDate,
                    ItemsForShipping = oi.OrderItems.Sum(i => i.Quantity),
                    OrderPrice = oi.OrderItems.Sum(i => i.Quantity*i.Price)
                };
            foreach (var i in someOrder)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
