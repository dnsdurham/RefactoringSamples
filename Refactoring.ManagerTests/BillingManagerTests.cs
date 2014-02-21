using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactoring.Managers;
using Refactoring.ManagerTests.Properties;
using Refactoring.ManagerTests.Mocks;

namespace Refactoring.ManagerTests
{
    [TestClass]
    public class BillingManagerTests
    {
        // NOTE: These tests are representative only. There would obviously be a lot more tests covering other permutations

        [TestMethod]
        public void BillingManager_GenerateStatement()
        {
            // This test is not using any mock factories or engines
            BillingManager manager = new BillingManager();

            string statement = manager.GenerateStatement(1);

            // We are using a sample statement from a resource here but this might have to be more complicated
            // in the real world
            Assert.AreEqual(Resources.SampleStatement, statement);
        }

        [TestMethod]
        public void BillingManager_GenerateHtmlStatement()
        {
            BillingManager manager = new BillingManager();

            string statement = manager.GenerateHtmlStatement(1);

            Assert.AreEqual(Resources.SampleHtmlStatement, statement);
        }
        
        public void BillingManager_GenerateStatementMocks()
        {
            // This test will show how to override the factories on the billing manager to use mock factories 
            BillingManager manager = new BillingManager();

            // Here is where I replace the default production factories with Mocks
            manager.EngineFactory = new MockEngineFactory();
            manager.AccessorFactory = new MockAccessorFactory();

            string statement = manager.GenerateStatement(1);

            // Note that we use the "MockSampleStatament" here for comparison
            //Assert.AreEqual(Resources.MockSampleStatement, statement);
        }
    }
}
