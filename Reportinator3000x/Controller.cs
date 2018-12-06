using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportLib;

namespace Reportinator3000x
{
    public class Controller
    {
        private ReportRepo repo = new ReportRepo();

        public void CreateReport(string ReportName)
        {
            repo.CreateReport(ReportName);
        }

        public void RemoveReport(string reportName)
        {
            repo.RemoveReport(reportName);
        }

        public void SetGlobalParameter(string Customer, string Email, int Interval, string ReportName)
        {
            ReportLib.Report report = null;
            foreach (ReportLib.Report r in repo.GetReports())
            {
                if (ReportName.Equals(r.ReportName))
                {
                    report = r;
                    report.Customer = Customer;
                    report.Email = Email;
                    report.Interval = Interval;
                }
            }
            if (report == null)
            {
                throw new Exception("Report does not exist.");
            }
        }

        public void AddModule(string reportName, int PageNr, string moduleName, string serialNumber)
        {
            ReportLib.Report report = null;
            foreach (ReportLib.Report r in repo.GetReports())
            {
                if (reportName.Equals(r.ReportName))
                {
                    report = r;
                    break;
                }
            }

            report.ChooseModules(PageNr, moduleName, serialNumber);

        }

        public ReportLib.Report GetReport(string reportName)
        {
            return repo.GetReport(reportName);
        }

        public List<Dictionary<string, string>> GetReportsOverview()
        {
            List<Dictionary<string, string>> reportItems = new List<Dictionary<string, string>>();

            foreach (ReportLib.Report report in repo.GetReports())
            {
                Dictionary<string, string> context = new Dictionary<string, string>();
                context["name"] = report.ReportName;
                context["customer"] = report.Customer;
                context["interval"] = report.Interval.ToString();
                reportItems.Add(context);
            }

            return reportItems;
        }


        public void RemovePage(int pageNr, string reportName)
        {
            repo.GetReport(reportName).RemovePage(pageNr);
        }
    }
}
