using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace FacebookAutomation
{
    public class Report
    {
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentReports extent;
        public static ExtentTest test;

        public static ExtentReports report()
        {
            if (extent == null)
            {

                string reportPath = @"C:\Users\vivek.g\source\repos\FacebookAutomation\FacebookAutomation\Report\TestReport.html";
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("OS", "Windows");
                extent.AddSystemInfo("UserName", "Vivek");
                extent.AddSystemInfo("ProviderName", "Vivek");
                extent.AddSystemInfo("Domain", "QA");
                extent.AddSystemInfo("Browser", "Chrome");
                extent.AddSystemInfo("ProjectName", "Facebook Automation");

                string conifgPath = @"C:\Users\vivek.g\source\repos\FacebookAutomation\FacebookAutomation\report.xml";
                htmlReporter.LoadConfig(conifgPath);

            }
            return extent;
        }
    }
}
