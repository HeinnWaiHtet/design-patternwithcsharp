using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class XMLLogger : Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"XML Log : {message}");
        }
    }
}
