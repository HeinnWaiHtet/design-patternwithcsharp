using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Demo1
{
    public class AbstractFactoryDemo1
    {
        public static void Run()
        {
            FurnitureFactory furnitureFactory = new ArtDecoFurniture();
            furnitureFactory.CreateCoffeTable().GetLegs();

            furnitureFactory = new ModernFurniture();
            furnitureFactory.CreateCoffeTable().GetLegs();
        }
    }
}
