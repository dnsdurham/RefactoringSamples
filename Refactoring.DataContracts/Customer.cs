using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.DataContracts
{
    public class Customer
    {
        public string Name { get; set; }

        public Rental[] Rentals { get; set; }
    }
}
