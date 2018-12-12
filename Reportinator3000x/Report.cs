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

        private void CreateReportBtnClick(object sender, EventArgs e)
        {
            int interval = 0;
            try
            {
                interval = int.Parse(IntervalInput.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("That is not a number, please only enter numbers!");
                return;
            }


            Control.CreateReport(NameInput.Text);
            Control.SetGlobalParameter(CustomerInput.Text, EmailInput.Text, interval, NameInput.Text);
            MessageBox.Show("Report created, refresh the main window please");

            //Reset global parameters to empty string
            string clear = "";
            CustomerInput.Text = clear;
            EmailInput.Text = clear;
            IntervalInput.Text = clear;
            NameInput.Text = clear;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Control.RemovePage(int.Parse(PageList.SelectedItems[0].SubItems[1].Text), NameInput.Text);
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void AddPageButton_Click(object sender, EventArgs e)
        {

        }
    }
}
