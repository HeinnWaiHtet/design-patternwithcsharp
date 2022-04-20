using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Demo1
{
    public class ArtDecoCoffeeTable : ICoffeeTable
    {
        public void GetLegs()
        {
            Console.WriteLine("4 Legs");
        }
    }
}
