using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_method
{
    public class HtmlReportGenerator : ReportGenerator
    {
        protected override void CollectData()
        {
            Console.WriteLine("Collecting data for HTML report...");
        }

        protected override void FormatData()
        {
            Console.WriteLine("Formatting data for HTML report...");
        }

        protected override void ExportReport()
        {
            Console.WriteLine("Exporting HTML report...");
        }
    }
}
