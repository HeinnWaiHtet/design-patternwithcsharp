using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class FactoryMethodDemo
    {
        public static void Run()
        {
            LoggerFactory factory = new ConsoleFactory();
            factory.GetLogger().Log("Console Log");

            factory = new XMLFactory();
            factory.GetLogger().Log("XML Log");
        }
    }
}
