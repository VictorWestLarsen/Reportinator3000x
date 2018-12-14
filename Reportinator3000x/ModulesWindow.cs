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
            
         
        
        }
    }
}
