using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportLib;

namespace Reportinator3000x
{
    class Controller
    {
        private List<ReportLib.Report> reports = new List<ReportLib.Report>();

        public void CreateReport(string ReportName)
        {
            
            ReportLib.Report report = new ReportLib.Report(ReportName);
            reports.Add(report);
            Console.WriteLine("Report Created!");
        }

        public void SetGlobalParameter(string Customer, string Email, int Interval, string ReportName)
        {
            ReportLib.Report report = null;
            foreach (ReportLib.Report r in reports) {
                if (ReportName.Equals(r.ReportName)) {
                    report = r;
                    report.Customer = Customer;
                    report.Email = Email;
                    report.Interval = Interval;
                }
            }
            if (report == null) {
                throw new Exception("Report does not exist.");
            }
        }

        public void AddModule(string reportName, int PageNr, string moduleName, string serialNumber)
        {
            ReportLib.Report report = null;
            foreach (ReportLib.Report r in reports) {
                if (reportName.Equals(r.ReportName)) {
                    report = r;
                    break;
                }
            }

            report.ChooseModules(PageNr, moduleName, serialNumber);

        }

    }
}
