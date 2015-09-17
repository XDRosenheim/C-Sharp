using System;
using System.Collections.Generic;

namespace OrderLib
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public decimal OrderAmount
        {
            get
            {
                decimal sum = 0;
                foreach (OrderItem oi in OrderItems)
                {
                    sum += oi.Quantity * oi.Price;
                }
                return sum;
            }
        }
        public List<OrderItem> OrderItems { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
        public Order()
        {
            OrderItems = new List<OrderItem>();
        }
        public Order(int orderId, DateTime orderDate)
            : this()
        {
            OrderId = orderId;
            OrderDate = orderDate;
        }
    }
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
    public class Address
    {
        public string StreetNr { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
