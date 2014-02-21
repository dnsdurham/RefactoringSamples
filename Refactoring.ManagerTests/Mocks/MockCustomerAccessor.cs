using Refactoring.ResourceAccessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.ManagerTests.Mocks
{
    class MockCustomerAccessor : ICustomerAccessor
    {
        public DataContracts.Customer GetCustomerById(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
