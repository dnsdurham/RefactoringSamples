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
            // Evaluate the class type name and return the correct engine
            // NOTE: We expect an interface for an engine (not an engine) to be passed in
            string typeName = typeof(T).Name;
            switch (typeName)
            {
                case "IPricingEngine":
                    {
                        return new PricingEngine() as T;
                    }
                case "IFrequentRenterEngine":
                    {
                        return new FrequentRenterEngine() as T;
                    }
                default:
                    throw new System.ArgumentException(typeName + " is not supported by the factory");
            }
        }
    }
}
