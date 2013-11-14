using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactoring.Managers;
using Refactoring.ManagerTests.Properties;

namespace Refactoring.ManagerTests
{
    [TestClass]
    public class BillingManagerTests
    {
        // NOTE: These tests are representative only. There would obviously be a lot more tests covering other permutations

        [TestMethod]
        public void BillingManager_GenerateStatement()
        {
            BillingManager manager = new BillingManager();

            string statement = manager.GenerateStatement(1);

            Assert.AreEqual(Resources.SampleStatement, statement);
        }

        [TestMethod]
        public void BillingManager_GenerateHtmlStatement()
        {
            BillingManager manager = new BillingManager();

            string statement = manager.GenerateHtmlStatement(1);

            Assert.AreEqual(Resources.SampleHtmlStatement, statement);
        }
    }
}
