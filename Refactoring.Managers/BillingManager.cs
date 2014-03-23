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

        string GenerateHtmlStatement(int customerId);
    }

    public class BillingManager : IBillingManager
    {
        // TODO: Other potential refactorings:
        // 1. Use a string template for text/html and collapse to a single GenerateStatement method
        // 2. Move the calculation of the total amount into a method in the PricingEngine that recursively calls GetPrice


        private ICustomerAccessor _customerAccessor;
        private IPricingEngine _pricingEngine;
        private IFrequentRenterEngine _renterEngine;

        public BillingManager(ICustomerAccessor customerAccessor, IPricingEngine pricingEngine, IFrequentRenterEngine renterEngine)
        {
            _customerAccessor = customerAccessor;
            _pricingEngine = pricingEngine;
            _renterEngine = renterEngine;
        }

        public string GenerateStatement(int customerId)
        {
            double totalAmount = 0;

            Customer customer = _customerAccessor.GetCustomerById(customerId);

            // setup the statement string builder and add the statement header
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Rental Record for " + customer.Name);
            sb.AppendLine();

            //calculate the dollar amount of rentals and add rental details to statement
            // also calculate frequent renter points
            foreach (var rental in customer.Rentals)
            {
                // create statement line for this rental
                sb.AppendLine(rental.MovieName + " " + _pricingEngine.GetPrice(rental).ToString());
                
                // sum the total amount
                totalAmount += _pricingEngine.GetPrice(rental);
            } 

            // add footer line that also show total frequent renter points earned
            sb.AppendLine();
            sb.AppendLine("Amount owed is " + totalAmount.ToString());
            sb.AppendLine();
            sb.Append("You have earned " 
                + _renterEngine.GetTotalPoints(customer.Rentals).ToString() 
                + " frequent renter points");

            return sb.ToString();
        }

        public string GenerateHtmlStatement(int customerId)
        {
            double totalAmount = 0;

            Customer customer = _customerAccessor.GetCustomerById(customerId);

            // setup the statement string builder and add the statement header
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<H1>Rental Record for <EM>" + customer.Name + "</EM></H1><P>");
            sb.AppendLine();

            //calculate the dollar amount of rentals and add rental details to statement
            // also calculate frequent renter points
            foreach (var rental in customer.Rentals)
            {
                // create statement line for this rental
                sb.AppendLine(rental.MovieName + " " + _pricingEngine.GetPrice(rental).ToString() + "<BR>");

                // sum the total amount
                totalAmount += _pricingEngine.GetPrice(rental);
            }

            // add footer line that also show total frequent renter points earned
            sb.AppendLine();
            sb.AppendLine("<P>Amount owed is <EM>" + totalAmount.ToString() + "</EM><P>");
            sb.AppendLine();
            sb.Append("You have earned <EM>"
                + _renterEngine.GetTotalPoints(customer.Rentals).ToString()
                + "</EM> frequent renter points");

            return sb.ToString();
        }
    }
}
