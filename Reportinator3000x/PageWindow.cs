using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportinator3000x
{
    public partial class PageWindow : Form
    {
        Controller control;
        string ReportName;
        int pageNr;
        public PageWindow(Controller con, string reportName, int pgNr)
        {
            InitializeComponent();
            control = con;
            ReportName = reportName;
            pageNr = pgNr;
            NameLabel.Text = reportName;
        }

        private void PageWindow_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            control.AddPage(PageNameInput.Text, ReportName);
            MessageBox.Show("Page added.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModulesWindow modulesWindow = new ModulesWindow(control, ReportName, pageNr);
            modulesWindow.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void EditPage_Click(object sender, EventArgs e)
        {

            // control.EditPage();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            ReportLib.Report r = control.GetReport(ReportName);
            ReportLib.Page p = r.GetPage(pageNr);
            moduleList.Items.Clear();
            foreach(ReportLib.Module module in p.GetModules()) {
                moduleList.Items.Add(new ListViewItem(new[] { module.ToString() }));
            }
        }
    }
}
