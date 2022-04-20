using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Demo1
{
    public class ArtDecoSofa : ISofa
    {
        public bool HasLegs() => false;

        public void Type() => Console.WriteLine("Square Type");
    }
}
