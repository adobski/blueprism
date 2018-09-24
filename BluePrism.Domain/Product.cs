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

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}