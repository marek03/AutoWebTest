using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebTest
{
    [TestFixture("Chrome")]
    [TestFixture("FireFox")]
    class CommonTest
    {
        IWebDriver _driver;
        string browser;

        public CommonTest(string browser)
        {
            this.browser = browser;
        }

        [SetUp]
        public void SetUp()
        {
            _driver = Driver.GetDriver(browser);
            LogClass.RunningTest(browser);
        }

        [TearDown]
        public void TearDown()
        {
            LogClass.TestResult();
        }
    }
}
