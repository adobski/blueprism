using System.Linq;
using BluePrism.Domain;
using BluePrism.Tests.Mocks;
using FluentAssertions;
using NUnit.Framework;

namespace BluePrism.Tests
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void Product_Get_A_Catalogue_Of_Product_Test()
        {
            var products = MockProducts.Get;

            products
                .Should().
                AllBeAssignableTo<Product>();
        }

        [Test]
        public void Product_Get_Price_Of_Product_Test()
        {
            var products = MockProducts.Get;

            products.FirstOrDefault(p => p.Id == 4).Price.Should().Be(121.50);

        }
    }
}