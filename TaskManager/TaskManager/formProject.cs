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
    public partial class formProject : Form
    {
        private Form1 mainForm { get; set; }
        private List<taskTemplate> template { get; set; }
        public formProject(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
            template = loadTaskGui();
        }

        private List<taskTemplate> loadTaskGui()
        {
            // Making of the tasks from file

            List<string> taskData = mainForm.loadSave();
            var list = new List<taskTemplate>();

            foreach (string collection in taskData)
            {
                string[] items = collection.Split(';');

                list.Add(new taskTemplate()
                {
                    task = items[0],
                    owner = items[1],
                    status = items[2],
                    date = items[3]
                });
            }
            return list;
        }

        private void resetTaskList(List<taskTemplate> data)
        {
            dgvTasks.DataSource = data;
        }

        private void formProject_Load(object sender, EventArgs e)
        {
            // Removes the border of the form
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // This code resets the datagridview, showing any new data added
            template = loadTaskGui();
            resetTaskList(template);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["formCreate"] as formCreate) != null)
            {
                Debug.WriteLine("formCreate is already open.");
            }
            else
            {
                // this is a mess but oh well
                formLaunch thing = new formLaunch(mainForm);
                formCreate fc = new formCreate(thing);
                fc.StartPosition = FormStartPosition.CenterScreen;
                fc.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            template = loadTaskGui();
            resetTaskList(template);
        }
    }
}
