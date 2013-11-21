using Refactoring.DataContracts;
using Refactoring.Engines;
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

    public class BillingManager : ManagerBase, IBillingManager
    {
        public string GenerateStatement(int customerId)
        {
            double totalAmount = 0;

            ICustomerAccessor custAccessor = this.AccessorFactory.CreateAccessor<ICustomerAccessor>(); // using our factory DI pattern
            Customer customer = custAccessor.GetCustomerById(customerId);

            IPricingEngine pricingEngine = this.EngineFactory.CreateEngine<IPricingEngine>();
            IFrequentRenterEngine frequentRenterEngine = this.EngineFactory.CreateEngine<IFrequentRenterEngine>();

            // setup the statement string builder and add the statement header
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Rental Record for " + customer.Name);
            sb.AppendLine();

            //calculate the dollar amount of rentals and add rental details to statement
            // also calculate frequent renter points
            foreach (var rental in customer.Rentals)
            {
                // create statement line for this rental
                sb.AppendLine(rental.MovieName + " " + pricingEngine.GetPrice(rental).ToString());
                
                // sum the total amount
                totalAmount += pricingEngine.GetPrice(rental);
            } 

            // add footer line that also show total frequent renter points earned
            sb.AppendLine();
            sb.AppendLine("Amount owed is " + totalAmount.ToString());
            sb.AppendLine();
            sb.Append("You have earned " 
                + frequentRenterEngine.GetTotalPoints(customer.Rentals).ToString() 
                + " frequent renter points");

            return sb.ToString();
        }
    }
}
