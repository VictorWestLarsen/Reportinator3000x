using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportLib;

namespace Reportinator3000x
{
    class ReportRepo
    {
        private List<ReportLib.Report> reports = new List<ReportLib.Report>();

        public ReportLib.Report GetReport(string reportName)
        {
            foreach (ReportLib.Report report in reports) {
                if (report.ReportName.Equals(reportName)) {
                    return report;
                }
            }
            return null;
        }

        public void CreateReport(string reportName)
        {
            ReportLib.Report report = new ReportLib.Report(reportName);
            reports.Add(report);
            Console.WriteLine("Report Created!");
        }

        public List<ReportLib.Report> GetReports()
        {
            return reports;
        }

    }
}
