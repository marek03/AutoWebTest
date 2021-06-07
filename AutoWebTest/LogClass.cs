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
            file.WriteLine("Running {0} test", browser);
        }

        public static void TestResult()
        {
            
        }
    }
}
