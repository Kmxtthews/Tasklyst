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
    public partial class formDeadlines : Form
    {
        public formDeadlines()
        {
            InitializeComponent();
        }

        private void formDeadlines_Load(object sender, EventArgs e)
        {
            // Removes the border of the form
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
    }
}
