﻿using OpenQA.Selenium;
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
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            _driver.Navigate().GoToUrl("https://teams.microsoft.com/");
            
            LogClass.UrlLoaded();
            
        }

        public static void EnterMail()
        {
            IWebElement login = _driver.FindElement(By.Name("loginfmt"));
            login.SendKeys("dlp.automation3@safeticadlptesting.onmicrosoft.com");
            login.SendKeys(Keys.Enter);
            
        }

        public static void EnterPassw()
        {
            IWebElement passw = _driver.FindElement(By.Name("passwd"));
            passw.SendKeys("Password.dlp");
            Wait();
            _driver.FindElement(By.Id("idSIButton9")).Click();
            //passw.SendKeys(Keys.Enter);
            
        }

        public static void StayNotLogged()
        {
            _driver.FindElement(By.Id("idBtn_Back")).Click();
            
        }

        public static void TryAgain()
        {
            _driver.FindElement(By.XPath("//*[contains(text(), 'Zkusit znovu')]")).Click();
        }

        public static void SendMessage()
        {
            _driver.FindElement(By.Id("app-bar-2a84919f-59d8-4441-a975-2a8c2643b741")).Click(); //kliknutí na tlačítko týmy
            
            _driver.FindElement(By.ClassName("channel-anchor")).Click(); //kliknutí na tlačítko test
            
            _driver.FindElement(By.Id("new-post-button")).Click(); //kliknutí na tlačítko nová konverzace
            
            IWebElement textbox = _driver.FindElement(By.XPath("//*[@id=\"cke_50_contents\"]/div"));
            textbox.SendKeys("Message");
            textbox.SendKeys(Keys.Enter);
        }

        public static void SendFile()
        {

        }

        public static void QuitBrowser()
        {
            _driver.Quit();
        }

        public static void Wait() { Thread.Sleep(2000); }
    }
}
