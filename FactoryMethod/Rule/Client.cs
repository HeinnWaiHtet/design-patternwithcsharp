using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.Rule
{
    public class Client
    {
        public void Run()
        {
            Console.WriteLine("Concrete Product 1");
            this.ClientCode(new ConcreteCreator1());
            Console.WriteLine("Concrete Product 2");
            this.ClientCode(new ConcreteCreator2());
        }

        private void ClientCode(Creator creator)
        {
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.SomeOperation());
        }
    }
}
