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

        public void ChangeReportName(string oldName, string newName)
        {
            ReportLib.Report report = GetReport(oldName);
            report.ReportName = newName;

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

        public void AddPage(string pageName, string reportName)
        {
            Page page = new Page();
            ReportLib.Report targetReport = repo.GetReport(reportName);
            page.Name = pageName;
            page.PageNo = targetReport.GetNewPageNr();
            targetReport.AddPage(page);
        }
        public void RemovePage(int pageNr, string reportName)
        {
            repo.GetReport(reportName).RemovePage(pageNr);
        }

        public Dictionary<string, string> GetReportData(string reportName)
        {
            ReportLib.Report report = repo.GetReport(reportName);
            Dictionary<string, string> context = new Dictionary<string, string>();
            context["name"] = report.ReportName;
            context["customer"] = report.Customer;
            context["interval"] = report.Interval.ToString();
            context["email"] = report.Email;
            return context;
        } 

        public List<string> GetPageNames(string reportName)
        {
            List<string> pageNames = new List<string>();
            foreach(Page page in repo.GetReport(reportName).GetPages()) {
                pageNames.Add(page.Name);
            }
            return pageNames;
        }

        public List<string> GetAvailableModuels()
        {
            List<string> AvailableModules = new List<string>();

            foreach (Modules module in Enum.GetValues(typeof(Modules)))
            {
                AvailableModules.Add(module.ToString());
            }

            return AvailableModules;
        }

        public List<string> GetRequiredParameters(string moduleName)
        {
            Module selectedModule = null;


            if (moduleName.Equals(Modules.IncomingRetailVehicles.ToString())) {
                selectedModule = new IncomingRetailVehicles(null);
            }
            else if (moduleName.Equals(Modules.MDSPerFuelTypeForSegment.ToString())) {
                selectedModule = new MDSPerFuelTypeForSegment(null);
            }
            else if (moduleName.Equals(Modules.SalesOverTime.ToString())) {
                selectedModule = new SalesOverTime(null);
            }
            else if (moduleName.Equals(Modules.StockOverTime.ToString())) {
                selectedModule = new StockOverTime(null);
            }
            else if (moduleName.Equals(Modules.StockPerMake.ToString())) {
                selectedModule = new StockPerMake(null);
            }

            if (selectedModule == null) {
                throw new Exception("Module does not exist");
            } 
            else {
                return selectedModule.GetRequiredParameters();
            }
        }
    }
}
