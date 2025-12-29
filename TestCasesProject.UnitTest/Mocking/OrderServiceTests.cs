using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestCasesProject.UnitTest.Mocking
{
    [TestFixture]
    class OrderServiceTests
    {
        [Test]
        public void PlaceOrder()
        {
            // arrange
            var order = new Order();
            var _storage = new Mock<IStorage>();
            var OrderService = new OrderService(_storage.Object);
            _storage.Setup(o => o.Store(order)).Returns(1);

            // Act
            var result = OrderService.PlaceOrder(order);

            //assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void PlaceOrder_Verify()
        {
            var order = new Order();
            var _storage = new Mock<IStorage>();
            var OrderService = new OrderService(_storage.Object);
            OrderService.PlaceOrder(order);
            _storage.Verify(s => s.Store(order)); // verify the state of objects
        }
    }
}
