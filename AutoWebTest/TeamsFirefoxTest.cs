using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebTest
{
    [TestFixture("FireFox")]
    class TeamsFirefoxTest : CommonTest
    {
        public TeamsFirefoxTest(string browser) : base(browser)
        {

        }

        [SetUp]
        public void SetUp()
        {
            Teams.LoadURL();
            Teams.AdvancedButton();
            Teams.EnterMail();
            Teams.EnterPassw();
            Teams.StayNotLogged(); 
        }

        [Test]
        public void SendTwoFiles()
        {
            Teams.SendTwoFiles();
        }

        [Test]
        public void SendThreeMessages()
        {
            Teams.SendThreeMessages();
        }

        [TearDown]
        public void TearDown()
        {
            //Teams.QuitBrowser();
        }
    }
}
