using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myOrdres
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new Order();
            order1.CustomerName = "Julie";
            order1.OrderId = 1000;

            Order order2 = new Order(1001, new DateTime(2015, 09, 14));
            order2.CustomerName = "Ruben von Trier";

            Order order3 = new Order(1003, new DateTime(2015, 09, 14))
            {
                OrderId = 1002,
                CustomerName = "Tor",
                OrderDate = new DateTime(2015, 09, 14)
            };

            Order order4 = new Order
            {
                OrderId = 1004,
                CustomerName = "Mark",
                BillingAddress = new Address
                {
                    StreetNr = "9",
                    City = "Ballerup",
                    Zip = "2750",
                    State = "DK"
                },
                OrderItems = new List<OrderItem>
                {
                    new OrderItem 
                    {
                        OrderItemId = 106,
                        Price = 27.50m, // +m = decimal, -m = Double
                        ProductName = "toiletruller",
                        Quantity = 8
                    },
                    new OrderItem 
                    {
                        OrderItemId = 107,
                        Price = 30.00m, // +m = decimal, -m = Double
                        ProductName = "toiletbørste",
                        Quantity = 1
                    },
                    new OrderItem 
                    {
                        OrderItemId = 108,
                        Price = 10.00m, // +m = decimal, -m = Double
                        ProductName = "Fisk",
                        Quantity = 2
                    }
                },
                OrderDate = new DateTime(2015, 09, 14)
            };

            String[] navne = { "Oliver", "kasper", "Steffan", "Flemming" };

            Console.WriteLine(order4.ToString());
            //Console.Write(order2.OrderDate);
            Console.Read();
        }
    }
}
