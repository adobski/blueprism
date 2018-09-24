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

        public int Id { get; private set; }
        public Customer Customer { get; private set; }
        public OrderStatus Status { get; private set; }
        public IList<OrderLine> OrderLines { get; private set; }
        public double DefaultPrice { get; private set; }
        public double ActualPrice { get; private set; }

        public void AddOrderLine(OrderLine orderline)
        {
            OrderLines.Add(orderline);

            Status = OrderStatus.SelectingProducts;

            DefaultPrice += orderline.TotalDefaultCost;
            ActualPrice += orderline.TotalActualCost;
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