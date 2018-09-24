using System.Collections.Generic;
using BluePrism.Domain;

namespace BluePrism.Tests.Mocks
{
    public static class MockCustomers
    {
        private static readonly IEnumerable<Customer> get = new List<Customer>()
        {
            new Customer(1,"Customer 1", "customer1@test.com"),
            new Customer(2, "Customer 2", "customer1@test.com"),
            new Customer(3, "Customer 3", "customer1@test.com"),
            new Customer(4, "Customer 4", "customer1@test.com"),
            new Customer(5, "customer 5", "customer1@test.com"),
        };

        public static IEnumerable<Customer> Get => get;
    }
}