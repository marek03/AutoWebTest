using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebTest
{
    class CommonTest
    {
        string browser;

        public CommonTest(string browser)
        {
            this.browser = browser;
        }

        [SetUp]
        public void SetUp()
        {
            LogClass.RunningTest(browser);
        }

        [TearDown]
        public void TearDown()
        {
            LogClass.TestResult();
        }
    }
}
