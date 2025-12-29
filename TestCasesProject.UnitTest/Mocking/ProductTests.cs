using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestCasesProject.UnitTest.Mocking
{
    [TestFixture]
    class ProductTests
    {
        [Test]
        public void GetPrice_GoldCustomer_Apply30PercentDiscount()
        {
            Product product = new Product { ListPrice = 100 };
            var result = product.GetPrice(new Customer { IsGold = true });
            Assert.That(result, Is.EqualTo(70));
        }

        [Test]
        public void GetPrice_GoldCustomer_Apply30PercentDiscount2()
        {
            var mockCustomer = new Mock<ICustomer>();
            Product product = new Product { ListPrice = 100 };
            mockCustomer.Setup(o => o.IsGold).Returns(true);
            var result = product.GetPrice(mockCustomer.Object);
            Assert.That(result, Is.EqualTo(70));
        }

        [Test]
        public void GetPrice_NotGoldCustomer_NoDiscount()
        {
            var mockCustomer = new Mock<ICustomer>();
            Product product = new Product { ListPrice = 100 };
            mockCustomer.Setup(o => o.IsGold).Returns(false);
            var result = product.GetPrice(mockCustomer.Object);
            Assert.That(result, Is.EqualTo(100));
        }
    }
}
