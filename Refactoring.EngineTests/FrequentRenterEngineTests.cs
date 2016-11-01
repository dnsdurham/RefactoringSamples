using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactoring.DataContracts;
using Refactoring.Engines;

namespace Refactoring.EngineTests
{
    [TestClass]
    public class FrequentRenterEngineTests
    {
        Rental[] SetupSampleRentals()
        {
            List<Rental> rentals = new List<Rental>();
            rentals.Add(new Rental { MovieName = "Jaws", DaysRented = 2, PriceCode = PriceCodeType.Regular });
            rentals.Add(new Rental { MovieName = "Star Wars", DaysRented = 3, PriceCode = PriceCodeType.Regular });
            rentals.Add(new Rental { MovieName = "Toy Story", DaysRented = 4, PriceCode = PriceCodeType.Childrens });
            rentals.Add(new Rental { MovieName = "Wall-E", DaysRented = 3, PriceCode = PriceCodeType.Childrens });
            rentals.Add(new Rental { MovieName = "Thor", DaysRented = 1, PriceCode = PriceCodeType.NewRelease });
            rentals.Add(new Rental { MovieName = "Superman", DaysRented = 2, PriceCode = PriceCodeType.NewRelease });

            return rentals.ToArray();
        }

        [TestMethod]
        [TestCategory("Unit: Frequent Renter Engine")]
        public void FrequentRenterEngine_GetTotalPoints()
        {
            EngineFactory factory = new EngineFactory();

            IFrequentRenterEngine engine = factory.CreateEngine<IFrequentRenterEngine>();

            var result = engine.GetTotalPoints(SetupSampleRentals());

            Assert.AreEqual(7, result);
        }
    }
}
