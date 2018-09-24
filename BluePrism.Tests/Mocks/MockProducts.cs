using System.Collections.Generic;
using BluePrism.Domain;

namespace BluePrism.Tests.Mocks
{
    public static class MockProducts
    {
        private static readonly IEnumerable<Product> get = new List<Product>()
        {
            new Product(1,"Product1", "Product 1 Description", 12.99),
            new Product(2, "Product2", "Product 2 Description", 21.50),
            new Product(3, "Product3", "Product 3 Description", 18.99),
            new Product(4, "Product4", "Product 4 Description", 121.50),
            new Product(5, "Product5", "Product 5 Description", 56.25),
        };

        public static IEnumerable<Product> Get => get;
    }
}