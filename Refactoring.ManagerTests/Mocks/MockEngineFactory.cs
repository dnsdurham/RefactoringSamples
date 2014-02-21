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
            // Evaluate the class type name and return the correct engine
            // NOTE: We expect an interface for an engine (not an engine) to be passed in
            // Here we are returning mocks of the engines instead of actual engine instances
            string typeName = typeof(T).Name;
            switch (typeName)
            {
                case "IFrequentRenterEngine":
                    {
                        return new MockFrequentRenterEngine() as T;
                    }
                case "IPricingEngine":
                    {
                        return new MockPricingEngine() as T;
                    }
                default:
                    throw new System.ArgumentException(typeName + " is not supported by the factory");
            }
        }
    }
}
