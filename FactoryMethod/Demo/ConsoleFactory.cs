using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    class ConsoleFactory : LoggerFactory
    {
        public override Logger GetLogger()
        {
            return new ConsoleLogger();
        }
    }
}
