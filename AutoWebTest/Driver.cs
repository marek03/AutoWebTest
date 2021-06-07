using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebTest
{
    class Driver
    {
        public static IWebDriver GetDriver(string browser)
        {
            IWebDriver _driver;

            if (browser == "Chrome")
            {
                _driver = new ChromeDriver();
            }
            else if (browser == "FireFox")
            {
                _driver = new FirefoxDriver();
            }
            else
            {
                _driver = null;
            }

            return _driver;
        }
    }
}
