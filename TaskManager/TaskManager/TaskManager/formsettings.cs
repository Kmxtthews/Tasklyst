using Microsoft.VisualBasic;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaskManager
{
    public partial class formsettings : Form
    {
        private Form1 mainForm { get; set; }
        public formsettings(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void saveLoader()
        {
            List<string> tempData = mainForm.loadSave();
            var thing = String.Join("\n", tempData);
            rtbSaveData.Text = thing;
        }

        private void formsettings_Load(object sender, EventArgs e)
        {
            // Removes the border of the form
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            // Loads the save into the raw text gui
            saveLoader();
        }

        public void saveRawInput(string[] rawData)
        {
            using (StreamWriter sw = new StreamWriter(mainForm.saveFileName, false))
            {
                foreach (string singleTask in rawData)
                {
                    sw.WriteLine(singleTask);
                    Debug.WriteLine(singleTask);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // gets text from rtbsavedata and adds it to ur save
            string text = rtbSaveData.Text;
            string[] rawSaveCandidate = text.Split('\n');
            saveRawInput(rawSaveCandidate);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.Create(mainForm.saveFileName).Close();
            rtbSaveData.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveLoader();
        }
    }
}
