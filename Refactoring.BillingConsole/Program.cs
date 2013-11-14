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
            int customerId = 0;

            Console.WriteLine("Enter the customer id [default = 1]:");
            string result = Console.ReadLine();
            if (Int32.TryParse(result, out customerId))
            {
                BillingManager manager = new BillingManager();
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
