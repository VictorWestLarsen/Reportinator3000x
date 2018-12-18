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
    public partial class ModulesWindow : Form
    {
        Controller control;
        Dictionary<string, TextBox> parameterBacking = new Dictionary<string, TextBox>();
        private string _ReportName;

        public ModulesWindow(Controller _control, string reportName, int pageNr)
        {
            control = _control;
            InitializeComponent();
            _ReportName = reportName;
            labelPageNrModules.Text = pageNr.ToString();
            labelReportNameModules.Text = reportName;

            List<string> listOfModules = new List<string>();
            listOfModules = control.GetAvailableModuels();

            foreach (string strings in listOfModules)
            {
                DropdownModules.Items.Add(strings);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ModulesWindow_Load(object sender, EventArgs e)
        {

        }

        private void DropdownModules_SelectedIndexChanged(object sender, EventArgs e)
        {
            ParameterPanel.Controls.Clear();
            List<string> requiredParams = control.GetRequiredParameters(DropdownModules.SelectedItem.ToString());

            for (int i = 0; i < requiredParams.Count; i++) {
                TextBox entry = new TextBox();
                ParameterPanel.Controls.Add(new Label() { Text = requiredParams[i]}, 0, i);
                ParameterPanel.Controls.Add(entry, 1, i);
                parameterBacking[requiredParams[i]] = entry;
            }
        }

        private void AddModuleBtn(object sender, EventArgs e)
        {
            string moduleName = DropdownModules.SelectedItem.ToString();
            List<string> requiredParams = control.GetRequiredParameters(moduleName);
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            int nr = int.Parse(labelPageNrModules.Text);

            foreach (string param in requiredParams)
            {
                parameters[param] = parameterBacking[param].ToString();
            }
            try
            {
                control.AddModule(_ReportName, nr, null, control.GetSerialNr(moduleName), parameters);
            }
            catch (NullReferenceException n)
            {
                MessageBox.Show("The page must be created before you can add modules.\nPlease click the \"Create\" button on the page window.");
            }

        }
    }
}
