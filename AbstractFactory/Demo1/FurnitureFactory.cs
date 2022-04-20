using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Demo1
{
    public abstract class FurnitureFactory
    {
        public abstract ICoffeeTable CreateCoffeTable();

        public abstract IChair CreateChair();

        public abstract ISofa CreateSofa();
    }
}
