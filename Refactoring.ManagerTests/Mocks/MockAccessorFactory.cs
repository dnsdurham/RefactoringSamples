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
            // Evaluate the class type name and return the correct accessor
            // NOTE: We expect an interface for an accessor (not an accessor) to be passed in
            // Here we are returning mocks of the accessor instead of actual accessor instances
            string typeName = typeof(T).Name;
            switch (typeName)
            {
                case "ICustomerAccessor":
                    {
                        return new MockCustomerAccessor() as T;
                    }
                default:
                    throw new System.ArgumentException(typeName + " is not supported by the factory");
            }

        }
    }
}
