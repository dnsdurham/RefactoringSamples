using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactoring.Managers;
using Refactoring.ManagerTests.Properties;
using Refactoring.ManagerTests.Mocks;
using Microsoft.Practices.Unity;
using Refactoring.ResourceAccessors;
using Refactoring.Engines;
using Microsoft.Practices.ServiceLocation;

namespace Refactoring.ManagerTests
{
    [TestClass]
    public class BillingManagerTests
    {

        [TestInitialize]
        public void Setup()
        {
            var container = new UnityContainer();

            container.RegisterType<IAccessorFactory, MockAccessorFactory>();
            container.RegisterType<IEngineFactory, MockEngineFactory>();

            container.RegisterType<IBillingManager, BillingManager>();
            container.RegisterType<IFrequentRenterEngine, MockFrequentRenterEngine>();
            container.RegisterType<IPricingEngine, MockPricingEngine>();
            container.RegisterType<ICustomerAccessor, MockCustomerAccessor>();

            UnityServiceLocator locator = new UnityServiceLocator(container);
            ServiceLocator.SetLocatorProvider(() => locator);
        }

        // NOTE: These tests are representative only. There would obviously be a lot more tests covering other permutations

        [TestMethod]
        public void BillingManager_GenerateStatement()
        {
            // This test is not using any mock factories or engines
            IBillingManager manager = ServiceLocator.Current.GetInstance<IBillingManager>();

            string statement = manager.GenerateStatement(1);

            // We are using a sample statement from a resource here but this might have to be more complicated
            // in the real world
            Assert.AreEqual(Resources.SampleStatement, statement);
        }

        [TestMethod]
        public void BillingManager_GenerateHtmlStatement()
        {
            // This test is not using any mock factories or engines
            IBillingManager manager = ServiceLocator.Current.GetInstance<IBillingManager>();

            string statement = manager.GenerateHtmlStatement(1);

            // We are using a sample statement from a resource here but this might have to be more complicated
            // in the real world
            Assert.AreEqual(Resources.SampleHtmlStatement, statement);
        }
        
        [TestMethod]
        public void BillingManager_GenerateStatementMocks()
        {
            // This test will show how to override the factories on the billing manager to use mock factories 
            IBillingManager manager = ServiceLocator.Current.GetInstance<IBillingManager>();

            string statement = manager.GenerateStatement(1);

            // Note that we use the "MockSampleStatament" here for comparison
            Assert.AreEqual(Resources.MockSampleStatement, statement);
        }
    }
}
