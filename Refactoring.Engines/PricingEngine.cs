using Refactoring.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Engines
{
    public interface IPricingEngine
    {
        double GetPrice(Rental rental);
    }
    class PricingEngine : IPricingEngine
    {
        public double GetPrice(Rental rental)
        {
            double thisAmount = 0;

            // calculate the price
            switch (rental.PriceCode)
            {
                case PriceCodeType.Regular:
                    thisAmount += 2;
                    if (rental.DaysRented > 2)
                    {
                        thisAmount += (rental.DaysRented - 2) * 1.5;
                    }
                    break;
                case PriceCodeType.Childrens:
                    thisAmount += 1.5;
                    if (rental.DaysRented > 3)
                    {
                        thisAmount += (rental.DaysRented - 3) * 1.5;
                    }
                    break;
                case PriceCodeType.NewRelease:
                    thisAmount += rental.DaysRented * 3;
                    break;
                default:
                    break;
            }

            return thisAmount;
        }
    }
}
