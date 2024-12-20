using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class formCreate : Form
    {
        // ref to form launch
        private formLaunch formLaunch { get; set; }
        public formCreate(formLaunch launcher)
        {
            // Boring stuff
            InitializeComponent();
            this.Text = "Tasklyte | Create a task! |";
            formLaunch = launcher;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Variables
            string task = tbTask.Text;
            string name = tbName.Text;

            bool stuck = rbStuck.Checked;
            bool working = rbWorking.Checked;

            DateTime date = dtpDate.Value;

            string radioResult = stuck ? "Stuck" : "Working on it";
            List<string> saveCandidate = [task, name, radioResult, date.ToString()];

            // Task instantiation data is sent to formLaunch

            formLaunch.taskCreated(task, name, radioResult, date.ToString());
            this.Close();
        }
    }
}
