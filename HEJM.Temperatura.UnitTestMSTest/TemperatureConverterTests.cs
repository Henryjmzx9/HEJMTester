using Microsoft.VisualStudio.TestTools.UnitTesting;
using HEJM.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEJM.Temperatura.Tests
{
    [TestClass]
    public class TemperatureConverterTests
    {
        private readonly TemperatureConverter converter = new TemperatureConverter();

        [TestMethod]
        public void CelsiusToFahrenheit_ZeroCelsius_Returns32Fahrenheit()
        {
            double result = converter.CelsiusToFahrenheit(0);
            Assert.AreEqual(32, result, 0.001);
        }

        [TestMethod]
        public void FahrenheitToCelsius_32Fahrenheit_ReturnsZeroCelsius()
        {
            double result = converter.FahrenheitToCelsius(32);
            Assert.AreEqual(0, result, 0.001);
        }

        [TestMethod]
        public void CelsiusToFahrenheit_NegativeValue_ReturnsCorrectResult()
        {
            double result = converter.CelsiusToFahrenheit(-40);
            Assert.AreEqual(-40, result, 0.001);
        }

        [TestMethod]
        public void FahrenheitToCelsius_NegativeValue_ReturnsCorrectResult()
        {
            double result = converter.FahrenheitToCelsius(-40);
            Assert.AreEqual(-40, result, 0.001);
        }
    }

}