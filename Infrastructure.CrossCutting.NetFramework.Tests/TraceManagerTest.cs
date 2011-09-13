using Infrastructure.CrossCutting.NetFramework.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace Infrastructure.CrossCutting.NetFramework.Tests
{


    /// <summary>
    ///This is a test class for TraceManagerTest and is intended
    ///to contain all TraceManagerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TraceManagerTest
    {

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for TraceManager Constructor
        ///</summary>
        [TestMethod()]
        public void TraceManagerConstructorTest()
        {
            TraceManager target = new TraceManager();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for TraceCritical
        ///</summary>
        [TestMethod()]
        public void TraceCriticalTest()
        {
            TraceManager target = new TraceManager(); // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.TraceCritical(message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TraceError
        ///</summary>
        [TestMethod()]
        public void TraceErrorTest()
        {
            TraceManager target = new TraceManager(); // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.TraceError(message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TraceInfo
        ///</summary>
        [TestMethod()]
        public void TraceInfoTest()
        {
            TraceManager target = new TraceManager(); // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.TraceInfo(message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TraceInternal
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Infrastructure.CrossCutting.NetFramework.dll")]
        public void TraceInternalTest()
        {
            TraceManager_Accessor target = new TraceManager_Accessor(); // TODO: Initialize to an appropriate value
            TraceEventType eventType = new TraceEventType(); // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            target.TraceInternal(eventType, message);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TraceStart
        ///</summary>
        [TestMethod()]
        public void TraceStartTest()
        {
            TraceManager target = new TraceManager(); // TODO: Initialize to an appropriate value
            target.TraceStart();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TraceStartLogicalOperation
        ///</summary>
        [TestMethod()]
        public void TraceStartLogicalOperationTest()
        {
            TraceManager target = new TraceManager(); // TODO: Initialize to an appropriate value
            string operationName = "NLayerApp"; // TODO: Initialize to an appropriate value
            target.TraceStartLogicalOperation(operationName);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TraceStop
        ///</summary>
        [TestMethod()]
        public void TraceStopTest()
        {
            TraceManager target = new TraceManager(); // TODO: Initialize to an appropriate value
            target.TraceStop();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TraceStopLogicalOperation
        ///</summary>
        [TestMethod()]
        public void TraceStopLogicalOperationTest()
        {
            TraceManager target = new TraceManager(); // TODO: Initialize to an appropriate value
            target.TraceStopLogicalOperation();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TraceWarning
        ///</summary>
        [TestMethod()]
        public void TraceWarningTest()
        {
            TraceManager target = new TraceManager(); // TODO: Initialize to an appropriate value
            string message = "TraceWarning"; // TODO: Initialize to an appropriate value
            target.TraceWarning(message);
            //As("A method that does not return a value cannot be verified.");
        }
    }
}
