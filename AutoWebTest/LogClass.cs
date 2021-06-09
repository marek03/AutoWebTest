using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoWebTest
{
    class LogClass
    {
        static StreamWriter file = new StreamWriter("Logs.txt");

        public static void RunningTest(string browser)
        {
            file.WriteLine("Running test in {0}.", browser);
        }

        public static void UrlLoaded()
        {
            file.WriteLine("Web successfully loaded.");
        }

        public static void UserLogged()
        {
            file.WriteLine("User successfully logged.");
        }

        public static void FileSent()
        {
            file.WriteLine("File successfully sent.");
        }

        public static void MessageSent()
        {
            file.WriteLine("Message successfully sent.");
        }

        public static void TwoFilesSent()
        {
            file.WriteLine("Two files successfully sent.");
        }

        public static void ThreeMessagesSent()
        {
            file.WriteLine("Three messages successfully sent.");
        }

        public static void TestResult()
        {
            
        }

        public static void CloseFile()
        {
            file.Close();
        }
    }
}
