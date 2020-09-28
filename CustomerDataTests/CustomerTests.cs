using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerData;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerData.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        
        [TestMethod()]
        public void CustomerTest()
        {
            // Arrange
            string expectedName = "Factory";
            int expectedAccNo = 252;
            String expectedType = "I";
            double expectedCharge = 1245.1d;

            // Act
            Customer testCustomer = new Customer(252, "Factory", "i", 1245.1d);

            //Assert
            //Assert.AreEqual(expectedAccNo, testCustomer.AccountNo);
            //Assert.AreEqual(expectedName, testCustomer.CustomerName);
            Assert.AreEqual(expectedType, testCustomer.CustomerType);
            //Assert.AreEqual(expectedCharge, testCustomer.ChargeAmount);

        }


        [TestMethod()]
        public void CalculateChargeResZeroTest()
        {
            // Arrange
            string custType = "R";
            double pwrUsage1 = 0;
            double expected = 6.0d;
            Customer customer1 = new Customer(1, "Andy", "R", 0);

            // Act
            double actual = customer1.CalculateCharge(custType, pwrUsage1, 0);

            // Assert
            Assert.AreEqual(expected,actual);
        }
        
        [TestMethod()]
        public void CalculateChargeResPositiveTest()
        {
            // Arrange
            string custType = "R";
            double pwrUsage1 = 1000;
            double expected = 58.0d;
            Customer customer1 = new Customer(1, "Andy", "R", 0);

            // Act
            double actual = customer1.CalculateCharge(custType, pwrUsage1, 0);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateChargeCommZeroTest()
        {
            // Arrange
            string custType = "C";
            double pwrUsage1 = 0;
            double expected = 60.0d;
            Customer customer2 = new Customer(251, "High on Cannabis", "C", 0);

            // Act
            double actual = customer2.CalculateCharge(custType, pwrUsage1, 0);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateChargeCommPositiveTest()
        {
            // Arrange
            string custType = "C";
            double pwrUsage1 = 1500;
            double expected = 82.50d;
            Customer customer2 = new Customer(251, "High on Cannabis", "C", 0);

            // Act
            double actual = customer2.CalculateCharge(custType, pwrUsage1, 0);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateChargeIndZeroTest()
        {
            // Arrange
            string custType = "I";
            double pwrUsage1 = 0, pwrUsage2 = 0;
            double expected = 116.0d;
            Customer customer3 = new Customer(134, "Scrap Metal Melter", "I", 0);

            // Act
            double actual = customer3.CalculateCharge(custType, pwrUsage1, pwrUsage2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void CalculateChargeIndPositiveTest()
        {
            // Arrange
            string custType = "I";
            double pwrUsage1 = 2000, pwrUsage2 = 2000;
            double expected = 209.0d;
            Customer customer3 = new Customer(134, "Scrap Metal Melter", "I", 0);

            // Act
            double actual = customer3.CalculateCharge(custType, pwrUsage1, pwrUsage2);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestMethod()]
        public void ToStringTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ToFileTest()
        {
            Assert.Fail();
        }
        
    }
}

namespace CustomerDataTests
{
    class CustomerTests
    {
    }
}
