using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory.Demo
{
    public abstract class ReportFactory
    {
        public abstract ReportHeader CreateReportHeader();

        public abstract ReportBody CreateReportBody();

        /// <summary>
        /// Create Report With Header and Body Based on Create ReportType
        /// </summary>
        public void Create()
        {
            var reportHeader = this.CreateReportHeader();
            var reportBody = this.CreateReportBody();
            reportHeader.GenerateHeader();
            reportBody.GenerateBody();
        }
    }
}
