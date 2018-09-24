using System.Collections.Generic;

namespace BluePrism.Domain
{
    public class Product
    {
        public Product(
            int id,
            string title,
            string description,
            double price
        )
        {
            Id = id;
            Title = title;
            Description = description;
            Price = price;
        }

        public int Id { get; }
        public string Title { get; }
        public string Description { get; }
        public double Price { get; }
    }
}