using Microsoft.VisualStudio.TestTools.UnitTesting;
using APPBASE.Services;

namespace APPBASE.Tests
{
    [TestClass]
    public class CalculatorTest
    {
        // Arrange
        protected int? nYEAR = 2005;
        protected int? nDAYS = 1;
        protected int? nQTY = 1;
        protected decimal? nPRICE = 500000;


        protected void Arrange_scenario_1()
        {
            // Arrange
            this.nYEAR = 2005;
            this.nDAYS = 1;
            this.nQTY = 1;
            decimal? nPRICE = 500000;
        }

        protected void Arrange_scenario_2()
        {
            // Arrange
            this.nYEAR = 2005;
            this.nDAYS = 2;
            this.nQTY = 2;
            decimal? nPRICE = 500000;
        }

        [TestMethod]
        public void Calculator_getDiscRate_7()
        {
            // Arrange
            this.Arrange_scenario_1();

            // Act
            ICalculator cal = new Calculator(this.nYEAR, this.nDAYS, this.nQTY, this.nPRICE);
            decimal? nValue = cal.getDiscRate();

            // Assert
            Assert.AreEqual(7, nValue);
        }

        [TestMethod]
        public void Calculator_getDiscRate_17()
        {
            // Arrange
            this.Arrange_scenario_2();

            // Act
            ICalculator cal = new Calculator(this.nYEAR, this.nDAYS, this.nQTY, this.nPRICE);
            decimal? nValue = cal.getDiscRate();

            // Assert
            Assert.AreEqual(17, nValue);
        }

        [TestMethod]
        public void Calculator_getGrossAmount_500rb()
        {
            // Arrange
            this.Arrange_scenario_1();

            // Act
            ICalculator cal = new Calculator(this.nYEAR, this.nDAYS, this.nQTY, this.nPRICE);
            decimal? nValue = cal.getGrossAmount();

            // Assert
            Assert.AreEqual(500000, nValue);
        }

        [TestMethod]
        public void Calculator_getGrossAmount_2Jt()
        {
            // Arrange
            this.Arrange_scenario_2();

            // Act
            ICalculator cal = new Calculator(this.nYEAR, this.nDAYS, this.nQTY, this.nPRICE);
            decimal? nValue = cal.getGrossAmount();

            // Assert
            Assert.AreEqual(2000000, nValue);
        }

        [TestMethod]
        public void Calculator_getNetAmount_465rb()
        {
            // Arrange
            this.Arrange_scenario_1();

            // Act
            ICalculator cal = new Calculator(this.nYEAR, this.nDAYS, this.nQTY, this.nPRICE);
            decimal? nValue = cal.getNetAmount();

            // Assert
            Assert.AreEqual(465000, nValue);
        }

    }
}
