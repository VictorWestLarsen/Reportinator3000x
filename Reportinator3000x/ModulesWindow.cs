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
        Controller control = new Controller();
        Dictionary<string, TextBox> parameterBacking = new Dictionary<string, TextBox>();

        public ModulesWindow()
        {
            InitializeComponent();
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
                ParameterPanel.Controls.Add(new Label() { Text = requiredParams[i]}, 0, i);
                ParameterPanel.Controls.Add(new TextBox(), 1, i);

            }
        }
    }
}
