using System.Collections.Generic;
using System.Linq;

namespace BluePrism.Domain
{
    public class Order
    {
        public Order(int id, Customer customer)
        {
            Id = id;
            Customer = customer;
            OrderLines = new List<OrderLine>();
        }

        public int Id { get; }
        public Customer Customer { get; }
        public OrderStatus Status { get; private set; }
        public IList<OrderLine> OrderLines { get; }
        public double DefaultPrice { get; private set; }
        public double ActualPrice { get; private set; }

        public void AddOrderLine(OrderLine orderLine)
        {
            OrderLines.Add(orderLine);

            Status = OrderStatus.SelectingProducts;

            DefaultPrice += orderLine.TotalDefaultCost;
            ActualPrice += orderLine.TotalActualCost;
        }

        public void RemoveOrderLine(OrderLine orderLine)
        {
            var itemToRemove = OrderLines.Single(o => o.Id == orderLine.Id);

            DefaultPrice -= orderLine.TotalDefaultCost;
            ActualPrice -= orderLine.TotalActualCost;

            OrderLines.Remove(itemToRemove);
        }

        public void ChangeOrderStatus(OrderStatus status)
        {
            Status = status;
        }
    }
}