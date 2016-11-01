using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactoring.DataContracts;
using Refactoring.Engines;

namespace Refactoring.EngineTests
{
    /// <summary>
    /// Summary description for PricingEngineTests
    /// </summary>
    [TestClass]
    public class PricingEngineTests
    {


        [TestMethod]
        [TestCategory("Unit: Pricing Engine")]
        public void PricingEngine_GetPrice()
        {
            EngineFactory factory = new EngineFactory();

            IPricingEngine engine = factory.CreateEngine<IPricingEngine>();

            // Basic Rental
            Rental rental = new Rental()
            {
                DaysRented = 2,
                MovieName = "Jaws",
                PriceCode = PriceCodeType.Regular
            };

            var result = engine.GetPrice(rental);
            Assert.AreEqual(2, result);

            // > 2 days
            rental.DaysRented = 3;
            result = engine.GetPrice(rental);
            Assert.AreEqual(3.5, result);

            // Childrens
            rental.PriceCode = PriceCodeType.Childrens;
            result = engine.GetPrice(rental);
            Assert.AreEqual(1.5, result);

            //// > 4 days
            //rental.DaysRented = 4;
            //result = engine.GetPrice(rental);
            //Assert.AreEqual(3, result);

            // New Release
            rental.PriceCode = PriceCodeType.NewRelease;
            rental.DaysRented = 3;
            result = engine.GetPrice(rental);
            Assert.AreEqual(9, result);
        }
    }
}
