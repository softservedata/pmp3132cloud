//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLog;
using NUnit.Framework;
using System;
using System.Threading;

namespace pmp3132
{
    //[TestClass]
    [TestFixture]
    //[Parallelizable(ParallelScope.All)]
    public class UnitTest1
    {
        public static Logger log = LogManager.GetLogger("rolling0"); // for NLog

        [OneTimeSetUp]
        public void BeforeAllMethods()
        {
            Console.WriteLine("ThreadID= " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("[OneTimeSetUp] BeforeAllMethods()");
            //MessageBox.Show("[OneTimeSetUp] BeforeAllMethods() ThreadID= " + Thread.CurrentThread.ManagedThreadId, "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            log.Info("\tBeforeAllMethods() done");
        }

        [OneTimeTearDown]
        public void AfterAllMethods()
        {
            Console.WriteLine("[OneTimeTearDown] AfterAllMethods()");
            //MessageBox.Show("[OneTimeTearDown] AfterAllMethods()", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            log.Info("\tAfterAllMethods() done");
        }

        [SetUp]
        public void SetUp()
        {
            Console.WriteLine("[SetUp] SetUp() ThreadID= " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("[SetUp] SetUp()");
            log.Info("\tSetUp() done");
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("[TearDown] TearDown()");
            log.Info("\tTearDown() done");
        }

        //[TestMethod]
        [Test]
        public void TestMethod1()
        {
            log.Info("\tTestMethod1() start");
            Console.WriteLine("[Test] TestMethod1() ThreadID= " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("[Test] TestMethod1()");
            Assert.AreEqual(10, 6 + 4);
            log.Info("\tTestMethod1() done");
        }

        [Test]
        public void TestMethod2(
            [Values("Hello", "World")]
            string s,
            [Random(1,10,5)]
            int x)
        {
            log.Info("\tTestMethod2() start");
            Console.WriteLine("Test] TestMethod2() ThreadID= " + Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Ok, s=" + s + " x=" + x);
            log.Info("\tTestMethod2() done");
        }

    }
}
