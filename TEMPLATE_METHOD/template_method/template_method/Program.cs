using template_method;

ReportGenerator pdfReport = new PdfReportGenerator();
Console.WriteLine("Generating PDF Report:");
pdfReport.GenerateReport();

Console.WriteLine();

// HTML Report
ReportGenerator htmlReport = new HtmlReportGenerator();
Console.WriteLine("Generating HTML Report:");
htmlReport.GenerateReport();