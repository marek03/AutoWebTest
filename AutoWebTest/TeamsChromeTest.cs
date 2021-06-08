using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebTest
{
    [TestFixture("Chrome")]
    class TeamsChromeTest : CommonTest
    {
        public TeamsChromeTest(string browser) : base(browser)
        {

        }

        [SetUp]
        public void SetUp()
        {
            Teams.LoadURL();
            Teams.EnterMail();
            Teams.EnterPassw();
            Teams.StayNotLogged();
        }

        [Test]
        public void SendFile()
        {
            Teams.SendFile();
            /*try
            {
                Teams.SendFile();
            }
            catch
            {
                Teams.TryAgain();
                Teams.SendFile();
            }*/

        }

        [Test]
        public void SendMessage()
        {
            Teams.SendMessage();
            /*try
            {
                Teams.SendMessage();            mužu použit assert pak třeba 
            }
            catch
            {
                Teams.TryAgain();
                Teams.SendMessage();
            }   */
        }

        [TearDown]
        public void TearDown()
        {
            //Teams.QuitBrowser();
        }
    }
}
