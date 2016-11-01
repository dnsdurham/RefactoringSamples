using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refactoring.Managers;

namespace Refactoring.IntegrationTests
{
    [TestClass]
    public class BillingManagerTests
    {
        //[TestMethod]
        //[TestCategory("Integration: Billing Manager")]
        //[DeploymentItem(@"Resources\SampleStatement.txt")]
        //public void BillingManager_GenerateStatement()
        //{
        //    // This test is not using any mock factories or engines
        //    BillingManager manager = new BillingManager();

        //    string statement = manager.GenerateStatement(1);

        //    // We are using a sample statement from a resource here but this might have to be more complicated
        //    // in the real world
        //    Assert.AreEqual(File.ReadAllText("SampleStatement.txt"), statement);
        //}

        //[TestMethod]
        //[TestCategory("Integration: Billing Manager")]
        //[DeploymentItem(@"Resources\SampleHtmlStatement.txt")]
        //public void BillingManager_GenerateHtmlStatement()
        //{
        //    // This test is not using any mock factories or engines
        //    BillingManager manager = new BillingManager();

        //    string statement = manager.GenerateHtmlStatement(1);

        //    // We are using a sample statement from a resource here but this might have to be more complicated
        //    // in the real world
        //    Assert.AreEqual(File.ReadAllText("SampleHtmlStatement.txt"), statement);
        //}
    }
}
