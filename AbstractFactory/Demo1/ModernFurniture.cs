using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Demo1
{
    public class ModernFurniture : FurnitureFactory
    {
        public override IChair CreateChair()
        {
            return new ModernChair();
        }

        public override ICoffeeTable CreateCoffeTable()
        {
            return new ModernCoffeeTable();
        }

        public override ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
