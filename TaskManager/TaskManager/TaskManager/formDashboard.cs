using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class formDashboard : Form
    {
        private Form1 mainForm { get; set; }
        public formDashboard(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
        }

        private void formDashboard_Load(object sender, EventArgs e)
        {
            // Removes the border of the form
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // Finds how many tasks there are in the save.
            int taskAmount = mainForm.checkTaskAmount();
        }
    }
}