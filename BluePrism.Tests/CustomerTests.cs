

using BluePrism.Domain;
using FluentAssertions;
using NUnit.Framework;

namespace BluePrism.Tests
{
    [TestFixture]
    public class CustomerTests
    {
        [Test]
        public void Customer_Can_Create_Customer_Test()
        {
            var customer = new Customer(1, "Andrew", "andrew@test.com");

            customer
                .Should()
                .BeOfType(typeof(Customer));

            customer.Name.Should().Be("Andrew");
        }
    }
}