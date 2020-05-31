using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalc.Services
{
    public class Logger
    {
        public Logger()
        {
            Console.WriteLine("Logger init...");
        }

        public void Log(string text)
        {
            Console.WriteLine("LOG: " + text);
        }
    }
}
