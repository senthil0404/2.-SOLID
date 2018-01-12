using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    // The Open/closed Principle says "A software module/class is open for extension and closed for modification
    // Tomorrow if we want to introduce new report we should not modify existing class
    // new report method should be extended
    public class ReportGeneration //  Wrong
    {
        public string GetDataFromDatabase()
        {
            return "Data";
        }
        public void ExportReport(string ReportType)
        {
            if (ReportType == "CRS")
            {
                // Report generation with employee data in Crystal Report.
            }
            if (ReportType == "PDF")
            {
                // Report generation with employee data in PDF.
            }
        }
    }

    public class ReportGenerationValid //  Correct
    {
        public string GetDataFromDatabase()
        {
            return "Data";
        }
        public virtual void ExportReport(string ReportType)
        {
            // Default Implementation
            // Export as text file
        }
    }

    public class ExcelReport : ReportGenerationValid
    {
        public override void ExportReport(string ReportType)
        {
            // Excel Report
        }
    }

    public class PDFReport : ReportGenerationValid
    {
        public override void ExportReport(string ReportType)
        {
            // PDF Report
        }
    }
}
