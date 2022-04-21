using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.Demo
{
    public class BuilderDemo
    {
        public static void Run()
        {
            Text text = Text.CreateBuilder
                .CreateColor("red")
                .CreateFont("Roman")
                .Build();

            Console.WriteLine($"Name : {text.displayValue}, Color : {text.color}," +
                $" Decoration : {text.decoration}, Font : {text.font}");
        }
    }
}
