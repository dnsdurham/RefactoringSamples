using Refactoring.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.ManagerTests.Mocks
{
    class MockPricingEngine : IPricingEngine
    {
        public double GetPrice(Refactoring.DataContracts.Rental rental)
        {
            // always return 1.0 for price
            return 1.0;
        }
    }
}
