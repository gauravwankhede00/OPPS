using NUnit.Framework;
using TestNinja.Fundamentals;
//using Assert = NUnit.Framework.Assert;

namespace TestCasesProject.UnitTest
{
     [TestFixture] //[TestClass]
    public class ReservationTests

    {
        [Test] //[TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrage
            var reservation = new Reservation();

            //Act
            var result = reservation.CanBeCancelledBy(new User() { IsAdmin = true });

            //Assert

           // Assert.IsTrue(result);
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_SameUserCancel_ReturnsTrue()
        {
            //Arrage
            var user = new User();
            var reservation = new Reservation();
            reservation.MadeBy = user;

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert

            //Assert.IsTrue(result);
            Assert.That(result, Is.True);

        }

        [Test]
        public void CanBeCancelledBy_UserCancel_ReturnsFalse()
        {
            //Arrage
            var reservation = new Reservation();
            reservation.MadeBy = new User();

            //Act
            var result = reservation.CanBeCancelledBy(new User());

            //Assert

            //Assert.IsFalse(result);
            Assert.That(result, Is.False);
        }

        [Test]
        public void CanBeCancelledBy_NotAdmin_ReturnsFalse()
        {
            //Arrage
            
            var reservation = new Reservation();
 
            //Act
            var result = reservation.CanBeCancelledBy(new User() { IsAdmin = false});

            //Assert

            //Assert.IsFalse(result);
            Assert.That(result, Is.False);

        }
    }
}