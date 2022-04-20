using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Demo1
{
    public class ModernSofa : ISofa
    {
        public bool HasLegs() => true;

        public void Type() => Console.WriteLine("Black Square Type");
    }
}
