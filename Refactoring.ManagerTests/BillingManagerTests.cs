using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactoring.Managers;
using Refactoring.ManagerTests.Properties;

namespace Refactoring.ManagerTests
{
    [TestClass]
    public class BillingManagerTests
    {
        [TestMethod]
        public void BillingManager_GenerateStatement()
        {
            BillingManager manager = new BillingManager();

            string statement = manager.GenerateStatement(1);

            Assert.AreEqual(Resources.SampleStatement, statement);
        }
    }
}
