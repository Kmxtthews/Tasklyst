using System.Diagnostics.Eventing.Reader;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.IO;
using System.Diagnostics;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        // Constants

        Color enterColour = Color.FromArgb(38, 37, 55);
        Color leaveColour = Color.FromArgb(32, 31, 48);
        formDashboard dashboard;
        formDeadlines deadlines;
        formsettings settings;
        formProject project;
        formLaunch launch;

        // Menu constants

        int menuExpandSpeed = 20;
        bool menuExpanded = false;
        bool sidebarExpanded = true;
        int sidebarExpandSpeed = 20;

        // Saving Constants

        public string saveFileName = "save.txt";
        public bool hasSave = false;


        public Form1()
        {
            InitializeComponent();

            // Title Customisation
            this.Text = "Tasklyte | Approaching Tasks Confidently |";
        }

        private void generateSave()
        {
            FileStream newFile = File.Create(saveFileName);
            newFile.Close();
        }

        public int checkTaskAmount()
        {
            if (!File.Exists(saveFileName))
            {
                throw new FileNotFoundException($"File not found: {saveFileName}");
            }
            IEnumerable<string> lines = File.ReadLines(saveFileName);
            return lines.Count();
        }

        //Determines whether a file has any contents or not
        private bool? checkFileContents(string fileName)
        {
            string line;
            bool? result = null;
            try
            {
                StreamReader sr = new StreamReader(fileName);
                line = sr.ReadLine();

                if (line == null)
                {
                    result = false;
                }
                else
                {
                    result = true;
                }

                sr.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"\"checkFileContents()\" failed: {e}");
            }
            finally
            {
                Debug.WriteLine($"File \"{fileName}\" contents were checked.");
            }

            return result;
        }

        public void resetMdi()
        {
            Debug.WriteLine($"Has save:{hasSave}\nDashboard: {dashboard}");
            if (hasSave)
            {
                if (dashboard == null)
                {
                    dashboard = new formDashboard(this);
                    dashboard.FormClosed += Dashboard_FormClosed;
                    dashboard.MdiParent = this;
                    dashboard.Dock = DockStyle.Fill;
                    dashboard.Show();
                }
                else
                {
                    dashboard.Activate();
                }
            }
            else
            {
                if (dashboard == null)
                {
                    launch = new formLaunch(this);
                    launch.FormClosed += Dashboard_FormClosed;
                    launch.MdiParent = this;
                    launch.Dock = DockStyle.Fill;
                    launch.Show();
                }
                else
                {
                    launch.Activate();
                }
            }
        }

        public List<string> loadSave()
        {
            List<string> taskList = new List<string>();
            string line;
            // Open save and read

            try
            {
                StreamReader sr = new StreamReader(saveFileName);
                line = sr.ReadLine();

                while (line != null)
                {
                    taskList.Add(line);
                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Load Failed: {e}");
            }
            finally
            {
                Debug.WriteLine("Loading Process Complete");
            }
            return taskList;
        }

        private void menuDropdown_Tick(object sender, EventArgs e)
        {
            if (!menuExpanded)
            {
                pnlProjects.Height += menuExpandSpeed;
                if (pnlProjects.Height >= 180)
                {
                    menuDropdown.Stop();
                    menuExpanded = true;
                }
            }
            else
            {
                pnlProjects.Height -= menuExpandSpeed;
                if (pnlProjects.Height <= 83)
                {
                    menuDropdown.Stop();
                    menuExpanded = false;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuDropdown.Start();

            if (!sidebarExpanded) sidebarDropdown.Start();
        }

        public void checkForSave()
        {
            if (File.Exists(saveFileName))
            {
                bool? hasContent = checkFileContents(saveFileName);
                Debug.WriteLine($"Save exists, File content is {hasContent}");
                if (hasContent == true)
                {
                    hasSave = true;
                }
                else
                {
                    hasSave = false;
                }
            }
            else
            {
                Debug.WriteLine("save doesn't exist, generating now.");
                generateSave();

                bool? hasContent = checkFileContents(saveFileName);
                if (hasContent == true)
                {
                    hasSave = true;
                }
                else
                {
                    hasSave = false;
                }
            }

            // Loading tasks from save file

            List<string> loadedSave = loadSave();

            // Individually handling tasks

            foreach (string s in loadedSave)
            {
                Debug.WriteLine($"{s}, this is all for now...");
            }
        }

        private void sideDropdown_Tick(object sender, EventArgs e)
        {
            if (sidebarExpanded)
            {
                sidebarMenu.Width -= menuExpandSpeed;

                if (sidebarMenu.Width <= 80)
                {
                    sidebarExpanded = false;
                    sidebarDropdown.Stop();
                }

            }
            else
            {
                sidebarMenu.Width += menuExpandSpeed;
                if (sidebarMenu.Width >= 360)
                {
                    sidebarExpanded = true;
                    sidebarDropdown.Stop();
                }
            }
        }

        private void btnSidebar_Click(object sender, EventArgs e)
        {
            sidebarDropdown.Start();
        }

        private void Dashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            // when closed the variable containing the new instance of the form is overwritten by null
            dashboard = null;
        }

        private void btnProject1_Click(object sender, EventArgs e)
        {
            if (project == null)
            {
                project = new formProject(this);
                project.FormClosed += Project_FormClosed;
                project.MdiParent = this;
                project.Dock = DockStyle.Fill;
                project.Show();
            }
            else
            {
                project.Activate();
            }
        }

        #region
        private void Project_FormClosed(object? sender, FormClosedEventArgs e)
        {
            // when closed the variable containing the new instance of the form is overwritten by null
            project = null;
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            resetMdi();
        }

        // btnDashboard hover effect

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            btnDashboard.BackColor = enterColour;
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = leaveColour;
        }

        // btnSettings hover effect 

        private void btnSettings_MouseEnter(object sender, EventArgs e)
        {
            btnSettings.BackColor = enterColour;
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            btnSettings.BackColor = leaveColour;
        }
        //btnProjects hover effect

        private void btnProjects_MouseEnter(object sender, EventArgs e)
        {
            btnProjects.BackColor = enterColour;
        }

        private void btnProjects_MouseLeave(object sender, EventArgs e)
        {
            btnProjects.BackColor = leaveColour;
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            // checks for previous saves

            checkForSave();

            // Opens either dashboard or launch form

            resetMdi();
        }

        private void btnProject1_MouseEnter(object sender, EventArgs e)
        {
            btnProject1.BackColor = enterColour;
        }

        private void btnProject1_MouseLeave(object sender, EventArgs e)
        {
            btnProject1.BackColor = leaveColour;
        }

        private void Settings_FormClosed(object? sender, FormClosedEventArgs e)
        {
            // when closed the variable containing the new instance of the form is overwritten by null
            settings = null;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (settings == null)
            {
                settings = new formsettings(this);
                settings.FormClosed += Settings_FormClosed;
                settings.MdiParent = this;
                settings.Dock = DockStyle.Fill;
                settings.Show();
            }else
            {
                settings.Activate();
            }
        }
    }
}