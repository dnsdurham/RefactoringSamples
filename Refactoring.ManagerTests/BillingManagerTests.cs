using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactoring.Managers;
using Refactoring.ManagerTests.Properties;
using Refactoring.ManagerTests.Mocks;

namespace Refactoring.ManagerTests
{
    [TestClass]
    public class BillingManagerTests
    {
        // *NOTE: This is a new version of the Billing Manager unit test that uses mocking for the new engines. The original unit test has been moved to Integration tests
        
        [TestMethod]
        [TestCategory("Unit: Billing Manager")]
        [DeploymentItem(@"Resources\MockSampleStatement.txt")]
        public void BillingManager_GenerateStatementMocks()
        {
            // This test will show how to override the factories on the billing manager to use mock factories 
            BillingManager manager = new BillingManager();

            // Here is where I replace the default production factories with Mocks
            manager.EngineFactory = new MockEngineFactory();
            manager.AccessorFactory = new MockAccessorFactory();

            string statement = manager.GenerateStatement(1);

            // Note that we use the "MockSampleStatament" here for comparison
            Assert.AreEqual(File.ReadAllText("MockSampleStatement.txt"), statement);
        }

        // *NOTE: This unit test is added for the new HTML statement feature

        [TestMethod]
        [TestCategory("Unit: Billing Manager")]
        [DeploymentItem(@"Resources\MockSampleHtmlStatement.txt")]
        public void BillingManager_GenerateHtmlStatementMocks()
        {
            // This test will show how to override the factories on the billing manager to use mock factories 
            BillingManager manager = new BillingManager();

            // Here is where I replace the default production factories with Mocks
            manager.EngineFactory = new MockEngineFactory();
            manager.AccessorFactory = new MockAccessorFactory();

            string statement = manager.GenerateHtmlStatement(1);

            // Note that we use the "MockSampleHtmlStatament" here for comparison
            Assert.AreEqual(File.ReadAllText("MockSampleHtmlStatement.txt"), statement);
        }
    }
}
