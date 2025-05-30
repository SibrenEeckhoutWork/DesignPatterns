using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_method
{
    public class PdfReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Collecting data for PDF report...");
        }

        protected override void FormatData()
        {
            Console.WriteLine("Formatting data for PDF report...");
        }

        protected override void ExportReport()
        {
            Console.WriteLine("Exporting PDF report...");
        }
    }

}
