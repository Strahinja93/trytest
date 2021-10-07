using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestNinja.TestFolder;

namespace TestNinja.UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
        {
            //Arrange
            var reservation = new Reservation();
            //Act
            reservation.CanBeCancelledBy(new User { IsAdmin = true });
            //Assert
        }
    }
}
