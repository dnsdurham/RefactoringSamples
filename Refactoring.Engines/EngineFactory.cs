using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Engines
{
    public interface IEngineFactory
    {
        T CreateEngine<T>() where T : class;
    }

    public class EngineFactory : IEngineFactory
    {
        public T CreateEngine<T>() where T : class
        {
            return ServiceLocator.Current.GetInstance<T>();
        }
    }
}
