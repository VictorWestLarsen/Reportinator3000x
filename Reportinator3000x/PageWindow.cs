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
        Controller control = new Controller();
        string ReportName;
        public PageWindow(Controller con, string reportName)
        {
            InitializeComponent();
            control = con;
            ReportName = reportName;
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
    }
}
