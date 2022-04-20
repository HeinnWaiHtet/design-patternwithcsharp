using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Demo
{
    public class HTMLReportBody : ReportBody
    {
        public override void GenerateBody()
        {
            Console.WriteLine("HTML Report Body");
        }
    }
}
