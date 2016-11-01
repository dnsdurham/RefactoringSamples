using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactoring.Managers;

namespace Refactoring.ManagerTests
{
    [TestClass]
    [DeploymentItem(@"Resources/SampleStatement.txt")]
    public class BillingManagerTests
    {
        [TestMethod]
        public void BillingManager_GenerateStatement()
        {
            BillingManager manager = new BillingManager();

            string statement = manager.GenerateStatement(1);

            Assert.AreEqual(File.ReadAllText("SampleStatement.txt"), statement);
        }
    }
}
