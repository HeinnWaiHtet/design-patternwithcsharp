using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Demo
{
    public class PDFReportHeader : ReportHeader
    {
        public override void GenerateHeader()
        {
            Console.WriteLine("PDF Report Header");
        }
    }
}
