using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Demo
{
    public class PDFReportFactory : ReportFactory
    {
        public override ReportHeader CreateReportHeader()
        {
            return new PDFReportHeader();
        }

        public override ReportBody CreateReportBody()
        {
            return new PDFReportBody();
        }
    }
}
