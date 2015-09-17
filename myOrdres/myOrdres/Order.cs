using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myOrdres
{
    class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string CustomerName { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
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
        public Order() // Metode - Constructor - No return type
        {
            OrderItems = new List<OrderItem>();
        }
        public Order(int orderId, DateTime orderDate) : this()
        {
            OrderId = orderId;
            OrderDate = orderDate;
        }
        public override string ToString()
        {
            string product = "";
            foreach (OrderItem item in OrderItems)
            {
                product += item;
            };
            string str = String.Format("###\n#Customer info\n###\nID: {0}. Date: {1}. Name: {2}. Adr.: {3}.", OrderId, OrderDate, CustomerName, BillingAddress +
                "\n\n###\n# Items\n###\n" + product + "\n");
            return str;
        }
    }

    class OrderItem
    {
        public int OrderItemId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public override string ToString()
        {
            return String.Format("ID: {0}.\nProduct: {1}.\nPrice: {2}.\nQuantity: {3}.\nTotal: {4}kr.\n\n", OrderItemId, ProductName, Price, Quantity, Price * Quantity);
        }
    }

    class Address
    {
        public string StreetNr { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public override string ToString()
        {
            return StreetNr +
                ", " + Zip +
                " " + City +
                ", " + State;
        }
    }
}
