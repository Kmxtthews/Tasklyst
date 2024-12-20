using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class Project
    {
        // Attributes
        private string task;
        private string owner;
        private string status;
        private string dueDate;

        // Saving Constants
        private string saveFileName = "save.txt";

        public Project(string task_, string owner_, string status_, string dueDate_)
        {
            task = task_;
            owner = owner_;
            status = status_;
            dueDate = dueDate_;
        }

        // Appends data to file
        public void saveAppend()
        {
            using (StreamWriter sw = File.AppendText(saveFileName))
            {
                string saveRaw = $"{task};{owner};{status};{dueDate};";
                sw.WriteLine(saveRaw);
            }
        }
    }
}
