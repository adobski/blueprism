using System.Linq;
using BluePrism.Domain;
using BluePrism.Tests.Mocks;
using FluentAssertions;
using NUnit.Framework;

namespace BluePrism.Tests
{
    [TestFixture]
    public class OrderTests
    {
        [Test]
        public void Customer_Can_Create_Order_Test()
        {
            var customer = MockCustomers.Get.FirstOrDefault(c => c.Id == 3);
            var order = new Order(1, customer);
            
            order.Should().NotBe(null);
        }

        [Test]
        public void Order_Status_Starts_As_SelectingProducts_Test()
        {
            var customer = MockCustomers.Get.FirstOrDefault(c => c.Id == 3);
            var order = new Order(1, customer);
            

            order.Status.Should().Be(OrderStatus.SelectingProducts);
        }

        [Test]
        public void Order_Status_Can_Be_Changed_To_ReadyForProcessing_Test()
        {
            var customer = MockCustomers.Get.FirstOrDefault(c => c.Id == 3);
            var order = new Order(1, customer);

            order.ChangeOrderStatus(OrderStatus.ReadyForProcessing);

            order.Status.Should().Be(OrderStatus.ReadyForProcessing);
        }

        [Test]
        public void Order_Status_Can_Be_Changed_To_ProcessingComplete_Test()
        {
            var customer = MockCustomers.Get.FirstOrDefault(c => c.Id == 3);
            var order = new Order(1, customer);

            order.ChangeOrderStatus(OrderStatus.ProcessingComplete);

            order.Status.Should().Be(OrderStatus.ProcessingComplete);
        }

        [Test]
        public void Order_Total_Cost_Changes_When_Adding_New_Product_Test()
        {
            var customer = MockCustomers.Get.FirstOrDefault(c => c.Id == 3);
            var order = new Order(1, customer);

            var product1 = MockProducts.Get.FirstOrDefault(p => p.Id == 3);
            var product2 = MockProducts.Get.FirstOrDefault(p => p.Id == 5);

            var orderLine1 = new OrderLine(1, product1, 1, null);
            var orderLine2 = new OrderLine(2, product2, 1, null);

            order.AddOrderLine(orderLine1);

            order.DefaultPrice.Should().Be(18.99);

            order.AddOrderLine(orderLine2);

            order.DefaultPrice.Should().Be(75.24);
        }

        [Test]
        public void Order_Total_Cost_Changes_When_Removing_Product_Test()
        {
            var customer = MockCustomers.Get.FirstOrDefault(c => c.Id == 3);
            var order = new Order(1, customer);

            var product1 = MockProducts.Get.FirstOrDefault(p => p.Id == 3);
            var product2 = MockProducts.Get.FirstOrDefault(p => p.Id == 5);

            var orderLine1 = new OrderLine(1, product1, 1, null);
            var orderLine2 = new OrderLine(2, product2, 1, null);

            order.AddOrderLine(orderLine1);

            order.DefaultPrice.Should().Be(18.99);

            order.AddOrderLine(orderLine2);

            order.DefaultPrice.Should().Be(75.24);

            order.RemoveOrderLine(orderLine1);

            order.DefaultPrice.Should().Be(56.25);
        }

        [Test]
        public void Order_With_Reduced_price_Test()
        {
            var customer = MockCustomers.Get.FirstOrDefault(c => c.Id == 3);
            var order = new Order(1, customer);

            var product1 = MockProducts.Get.FirstOrDefault(p => p.Id == 3);
            var product2 = MockProducts.Get.FirstOrDefault(p => p.Id == 5);

            var orderLine1 = new OrderLine(1, product1, 1, 5.00);
            var orderLine2 = new OrderLine(2, product2, 1, 35.00);

            order.AddOrderLine(orderLine1);

            order.DefaultPrice.Should().Be(18.99);

            order.AddOrderLine(orderLine2);

            order.DefaultPrice.Should().Be(75.24);
        }
    }
}