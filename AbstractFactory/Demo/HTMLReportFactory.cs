using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Demo
{
    public class HTMLReportFactory : ReportFactory
    {
        public override ReportHeader CreateReportHeader()
        {
            return new HTMLReportHeader();
        }

        public override ReportBody CreateReportBody()
        {
            return new HTMLReportBody();
        }
    }
}
