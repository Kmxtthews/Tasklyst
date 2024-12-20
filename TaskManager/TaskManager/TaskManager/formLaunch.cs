using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class formLaunch : Form
    {
        private Form1 mainForm { get; set; }
        public formLaunch(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["formCreate"] as formCreate) != null)
            {
                Debug.WriteLine("formCreate is already open.");
            }
            else
            {
                formCreate fc = new formCreate(this);
                fc.StartPosition = FormStartPosition.CenterScreen;
                fc.Show();
            }
        }

        public void taskCreated(string task_, string name_, string radioResult_, string date)
        {
            Project newTask = new Project(task_, name_, radioResult_, date);
            newTask.saveAppend();
            Debug.WriteLine("Task created, running resetMDI.");
            mainForm.checkForSave();
            
            if (!mainForm.hasSave)
            {
                mainForm.resetMdi();
            }
        }
    }
}
