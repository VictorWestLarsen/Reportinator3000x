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
    public partial class Report : Form
    {
        private Controller Control;
        public Report(Controller control)
        {
            InitializeComponent();
            Control = control;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Control.CreateReport(NameInput.Text);
            int interval = int.Parse(IntervalInput.Text);
            Control.SetGlobalParameter(CustomerInput.Text, EmailInput.Text, interval, NameInput.Text);
            MessageBox.Show("Report created, refresh the main window please");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
