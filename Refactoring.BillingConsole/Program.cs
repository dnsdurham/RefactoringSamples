using Microsoft.Practices.ServiceLocation;
using Refactoring.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.BillingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Bootstraper.Initialize();

            int customerId = 0;

            Console.WriteLine("Enter the customer id [default = 1]:");
            string result = Console.ReadLine();
            result = String.IsNullOrEmpty(result) ? "1" : result; // handle a default value

            if (Int32.TryParse(result, out customerId))
            {
                IBillingManager manager = ServiceLocator.Current.GetInstance<IBillingManager>();
                string statement = manager.GenerateStatement(customerId);
                Console.Write(statement);
            }
            else
            {
                Console.WriteLine("Invalid customer id");
            }

            Console.ReadLine();
        }
    }
}
