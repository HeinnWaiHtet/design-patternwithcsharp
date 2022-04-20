using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Demo
{
    public class AbstractFactoryDemo
    {
        public static void Run()
        {
            ReportFactory reportFactory = new HTMLReportFactory();
            reportFactory.Create();
            reportFactory = new PDFReportFactory();
            reportFactory.Create();
        }
    }
}
