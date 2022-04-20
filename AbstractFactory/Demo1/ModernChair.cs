using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Demo1
{
    public class ModernChair : IChair
    {
        public bool IsAvailable() => true;

        public bool IsDouble() => false;
    }
}
