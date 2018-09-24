using System.Runtime.InteropServices.ComTypes;

namespace BluePrism.Domain
{
    public class OrderLine
    {
        public OrderLine(int id, Product product, int quantity, double? costPerUnitCharged)
        {
            Id = id;
            Product = product;
            Quantity = quantity;
            CostPerUnitCharged = costPerUnitCharged;
            TotalDefaultCost = product.Price * quantity;

            TotalActualCost = CostPerUnitCharged * quantity ?? Product.Price * quantity;
        }

        public int Id { get; }
        public Product Product { get; }
        public int Quantity { get; }
        public double? CostPerUnitCharged { get; }
        public double TotalDefaultCost { get; }
        public double TotalActualCost { get; }
    }
}