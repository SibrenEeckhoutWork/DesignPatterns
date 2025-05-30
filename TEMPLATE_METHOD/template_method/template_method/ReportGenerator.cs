using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_method
{
    public abstract class ReportGenerator
    {
        public void GenerateReport()
        {
            CollectData();
            FormatData();
            ExportReport();
        }

        // Stappen van het algoritme
        protected abstract void CollectData();
        protected abstract void FormatData();
        protected abstract void ExportReport();
    }
}
