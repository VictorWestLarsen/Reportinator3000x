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
    public partial class EditReportWindow : Form
    {
        private Controller Control;
        string oldName;
        public EditReportWindow(Controller control, Dictionary<string, string> reportData)
        {
            InitializeComponent();
            Control = control;
            EmailInput.Text = reportData["email"];
            CustomerInput.Text = reportData["customer"];
            IntervalInput.Text = reportData["interval"];
            ReportNameInput.Text = reportData["name"];
            oldName = reportData["name"];
        }

        private void EditReportWindow_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Control.ChangeReportName(oldName, ReportNameInput.Text);
            Control.SetGlobalParameter(CustomerInput.Text, EmailInput.Text, int.Parse(IntervalInput.Text), ReportNameInput.Text);
            oldName = ReportNameInput.Text;
            MessageBox.Show("Report has been modified.");
        }

        private void CustomerInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadPageList()
        {
            PageList.Items.Clear();
            foreach(string pageName in Control.GetPageNames(oldName)) {
                ListViewItem row = new ListViewItem(pageName);
                PageList.Items.Add(row);
            }
        }

        private void AddPageButton_Click(object sender, EventArgs e)
        {
           PageWindow pageWindow = new PageWindow(Control, oldName);
            pageWindow.Show();
        }
    }
}
