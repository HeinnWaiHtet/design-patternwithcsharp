using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Demo1
{
    public class ArtDecoFurniture : FurnitureFactory
    {
        public override IChair CreateChair()
        {
            return new ArtDecoChair();
        }

        public override ICoffeeTable CreateCoffeTable()
        {
            return new ArtDecoCoffeeTable();
        }

        public override ISofa CreateSofa()
        {
            return new ArtDecoSofa();
        }
    }
}
