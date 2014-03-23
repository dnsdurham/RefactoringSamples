using Microsoft.Practices.ServiceLocation;
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
            return ServiceLocator.Current.GetInstance<T>();
        }
    }
}
