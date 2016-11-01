using Refactoring.DataContracts;

namespace Refactoring.Engines
{
    public interface IFrequentRenterEngine
    {
        int GetTotalPoints(Rental[] rentals);
    }
    class FrequentRenterEngine : IFrequentRenterEngine
    {
        public int GetTotalPoints(Rental[] rentals)
        {
            int frequentRenterPoints = 0;

            foreach (var rental in rentals)
            {
                //calculate the frequent renter points
                frequentRenterPoints++;
                // add bonus points for two day new release rental
                if (rental.PriceCode == PriceCodeType.NewRelease && rental.DaysRented > 1)
                {
                    frequentRenterPoints++;
                }
            }

            return frequentRenterPoints;
        }
    }
}
