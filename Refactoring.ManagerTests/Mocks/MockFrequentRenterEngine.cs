using Refactoring.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.ManagerTests.Mocks
{
    class MockFrequentRenterEngine : IFrequentRenterEngine
    {
        public int GetTotalPoints(Refactoring.DataContracts.Rental[] rentals)
        {
            throw new NotImplementedException();
        }
    }
}
