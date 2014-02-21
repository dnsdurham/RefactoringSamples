using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.ResourceAccessors
{
    public interface IAccessorFactory
    {
        T CreateAccessor<T>() where T : class;
    }

    public class AccessorFactory : IAccessorFactory
    {
        public T CreateAccessor<T>() where T : class
        {
            // Evaluate the class type name and return the correct accessor
            // NOTE: We expect an interface for an accessor (not an accessor) to be passed in
            string typeName = typeof(T).Name;
            switch (typeName)
            {
                case "ICustomerAccessor":
                    {
                        return new CustomerAccessor() as T;
                    }
                default:
                    throw new System.ArgumentException(typeName + " is not supported by the factory");
            }
        }
    }
}
