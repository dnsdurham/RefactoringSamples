using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Refactoring.Engines;
using Refactoring.Managers;
using Refactoring.ResourceAccessors;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.BillingConsole
{
    public class Bootstraper
    {
        public static void Initialize()
        {
            var container = new UnityContainer();

            container.RegisterType<IAccessorFactory, AccessorFactory>();
            container.RegisterType<IEngineFactory, EngineFactory>();
            
            container.RegisterType<IBillingManager, BillingManager>();
            container.RegisterType<IFrequentRenterEngine, FrequentRenterEngine>();
            container.RegisterType<IPricingEngine, PricingEngine>();
            container.RegisterType<ICustomerAccessor, CustomerAccessor>();

            container.RegisterType(typeof(DbContext), typeof(ClientDataContext));

            container.RegisterInstance(new ClientDataContextAdapter(container.Resolve<DbContext>()), new HierarchicalLifetimeManager());
            container.RegisterType<IDbSetFactory>(new InjectionFactory(con => con.Resolve<ClientDataContextAdapter>()));
            container.RegisterType<IDbContext>(new InjectionFactory(con => con.Resolve<ClientDataContextAdapter>()));

            UnityServiceLocator locator = new UnityServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => locator);
        }
    }
}
