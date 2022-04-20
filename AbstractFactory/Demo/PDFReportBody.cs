using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Demo
{
    public class PDFReportBody : ReportBody
    {
        public override void GenerateBody()
        {
            Console.WriteLine("PDF Report Body");
        }
    }
}
