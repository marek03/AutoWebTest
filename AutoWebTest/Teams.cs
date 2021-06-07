using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoWebTest
{
    class Teams
    {
        static IWebDriver _driver = CommonTest._driver;

        public static void LoadURL()
        {
            _driver.Navigate().GoToUrl("https://teams.microsoft.com/");
            LogClass.UrlLoaded();
            Wait();
        }

        public static void EnterMail()
        {
            IWebElement login = _driver.FindElement(By.Name("loginfmt"));
            login.SendKeys("dlp.automation3@safeticadlptesting.onmicrosoft.com");
            login.SendKeys(Keys.Enter);
            Wait();
        }

        public static void EnterPassw()
        {
            IWebElement passw = _driver.FindElement(By.Name("passwd"));
            passw.SendKeys("Password.dlp");
            passw.SendKeys(Keys.Enter);
            Wait();
        }

        public static void StayNotLogged()
        {
            _driver.FindElement(By.Id("idBtn_Back")).Click();
            Wait();
        }

        public static void QuitBrowser()
        {
            _driver.Quit();
        }

        public static void Wait() { Thread.Sleep(4000); }
    }
}
