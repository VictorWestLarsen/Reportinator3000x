using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Reportinator3000x
{
    public partial class MainWindow2 : Form
    {
        Controller control = new Controller();
        public MainWindow2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string reportName = ReportList.SelectedItems[0].SubItems[0].Text;
            control.RemoveReport(reportName);
            RefreshBtn_Click(null, null);
        }
        private void CreateReportBtnClick(object sender, EventArgs e)
        {
            Report report = new Report(control);
            report.Show();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            List<Dictionary<string, string>> data = control.GetReportsOverview();
            ReportList.Items.Clear();
            foreach(Dictionary<string, string> context in data) {
                ListViewItem row = new ListViewItem(new[] { context["name"], context["customer"], context["interval"] });
                ReportList.Items.Add(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditReportWindow editReport = new EditReportWindow(control);
            editReport.Show();
        }
    }
}
