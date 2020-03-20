using Microsoft.VisualStudio.TestTools.UnitTesting;
using APPBASE.Models;

namespace APPBASE.Tests
{
    [TestClass]
    public class CarRepositoryTest
    {
        [TestMethod]
        public void Car_Create_OK()
        {

            // Arrange
            BaseEntity car = new Car()
            {
                price = 500000,
                year = 2010
            };
            Repository crud = new CarRepository(car, 10);

            // Act
            crud.Create();

            // Assert
            Assert.IsTrue(crud.getStatus());
        }

        [TestMethod]
        public void Car_Update_OK()
        {

            // Arrange
            BaseEntity car = new Car()
            {
                price = 500000,
                year = 2010
            };
            Repository crud = new CarRepository(car, 10);

            // Act
            crud.Update();

            // Assert
            Assert.IsTrue(crud.getStatus());
        }


        [TestMethod]
        public void Car_Delete_OK()
        {

            // Arrange
            BaseEntity car = new Car()
            {
                price = 500000,
                year = 2010
            };
            Repository crud = new CarRepository(car, 10);

            // Act
            crud.Delete(14);

            // Assert
            Assert.IsTrue(crud.getStatus());
        }

    }
}
