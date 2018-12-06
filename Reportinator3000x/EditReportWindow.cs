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
        public EditReportWindow(Controller control, Dictionary<string, string> reportData)
        {
            InitializeComponent();
            Control = control;
            EmailInput.Text = reportData["email"];
            CustomerInput.Text = reportData["customer"];
            IntervalInput.Text = reportData["interval"];
            ReportNameInput.Text = reportData["name"];
        }

        private void EditReportWindow_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
