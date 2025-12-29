using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestCasesProject.UnitTest
{
    [TestFixture]
    class CustomerControllerTests
    {
        private CustomerController controller;
        [SetUp]
        public void SetUp()
        {
            controller = new CustomerController();
        }
        [Test]
        public void GetCustomer_IdIsZero_ResultNotFound()
        {
            var result = controller.GetCustomer(0);
            Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsZero_ResultOk()
        {
            var result = controller.GetCustomer(1);
            Assert.That(result, Is.InstanceOf<Ok>());
        }
    }
}
