using Refactoring.ResourceAccessors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.ManagerTests.Mocks
{
    class MockAccessorFactory : IAccessorFactory
    {
        public T CreateAccessor<T>() where T : class
        {
            throw new NotImplementedException();
        }
    }
}
