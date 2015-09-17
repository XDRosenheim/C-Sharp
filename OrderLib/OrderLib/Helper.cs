using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLib
{
    public class Helper
    {
        public static List<Order> makeOrders()
        {
            List<Order> Orders = new List<Order>();

            Order or1 = new Order
            {
                OrderId = 1000,
                CustomerName = "Abrek Abreksen",
                OrderDate = DateTime.Parse("13/08/2013")

            };
            or1.OrderItems.Add(new OrderItem
            {
                OrderItemId = 1,
                ProductName = "Appelsin",
                Price = 2.25m,
                Quantity = 4,
            });

            or1.OrderItems.Add(new OrderItem
            {
                OrderItemId = 2,
                ProductName = "Banan",
                Price = 1.95m,
                Quantity = 6
            });
            or1.OrderItems.Add(new OrderItem
            {
                OrderItemId = 3,
                ProductName = "Grape",
                Price = 4.00m,
                Quantity = 2
            });
            Orders.Add(or1);
            Order or2 = new Order
            {

                OrderId = 1001,
                CustomerName = "Morten Mortensen",
                OrderDate = DateTime.Parse("12/08/2013")

            };
            or2.OrderItems.Add(new OrderItem
            {
                OrderItemId = 4,
                ProductName = "Guldbarre",
                Price = 8.00m,
                Quantity = 10
            });
            or2.OrderItems.Add(new OrderItem
            {
                OrderItemId = 5,
                ProductName = "Sneakers",
                Price = 13.00m,
                Quantity = 3
            });
            or2.OrderItems.Add(new OrderItem
            {
                OrderItemId = 6,
                ProductName = "Mars Bar",
                Price = 12.00m,
                Quantity = 5
            });
            Orders.Add(or2);
            Order or3 = new Order
            {
                OrderId = 1002,
                CustomerName = "Peter PeterMedTsen",
                OrderDate = DateTime.Parse("14/08/2013")
            };
            or3.OrderItems.Add(new OrderItem
            {
                OrderItemId = 7,
                ProductName = "Mel",
                Price = 17.50m,
                Quantity = 1
            });
            or3.OrderItems.Add(new OrderItem
            {
                OrderItemId = 8,
                ProductName = "Sukker",
                Price = 20.95m,
                Quantity = 2
            });
            or3.OrderItems.Add(new OrderItem
            {
                OrderItemId = 9,
                ProductName = "Gryn",
                Price = 14.75m,
                Quantity = 1
            });
            Orders.Add(or3);
            return Orders;
        }
    }

}
