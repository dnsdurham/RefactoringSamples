using Refactoring.DataContracts;
using Refactoring.ResourceAccessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Managers
{
    public interface IBillingManager
    {
        string GenerateStatement(int customerId);
    }

    public class BillingManager : ManageBase, IBillingManager
    {
        public string GenerateStatement(int customerId)
        {
            double totalAmount = 0;
            int frequentRenterPoints = 0;

            ICustomerAccessor custAccessor = this.AccessorFactory.CreateAccessor<ICustomerAccessor>(); // using our factory DI pattern
            Customer customer = custAccessor.GetCustomerById(customerId);

            // setup the statement string builder and add the statement header
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Rental Record for " + customer.Name);
            sb.AppendLine();

            //calculate the dollar amount of rentals and add rental details to statement
            // also calculate frequent renter points
            foreach (var rental in customer.Rentals)
            {
                double thisAmount = 0;

                // calculate the price
                switch (rental.PriceCode)
                {
                    case PriceCodeType.Regular:
                        thisAmount += 2;
                        if (rental.DaysRented >2)
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

                //calculate the frequent renter points
                frequentRenterPoints++;
                // add bonus points for two day new release rental
                if (rental.PriceCode == PriceCodeType.NewRelease && rental.DaysRented > 1)
                {
                    frequentRenterPoints++;
                }

                // create statement line for this rental
                sb.AppendLine(rental.MovieName + " " + thisAmount.ToString());
                
                // sum the total amount
                totalAmount += thisAmount;
            } 

            // add footer line that also show total frequent renter points earned
            sb.AppendLine();
            sb.AppendLine("Amount owed is " + totalAmount.ToString());
            sb.AppendLine();
            sb.Append("You have earned " + frequentRenterPoints.ToString() + " frequent renter points");

            return sb.ToString();
        }
    }
}
