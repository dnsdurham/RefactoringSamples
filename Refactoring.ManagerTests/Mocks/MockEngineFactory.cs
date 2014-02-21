using Refactoring.Engines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.ManagerTests.Mocks
{
    class MockEngineFactory : IEngineFactory
    {
        public T CreateEngine<T>() where T : class
        {
            throw new NotImplementedException();
        }
    }
}
