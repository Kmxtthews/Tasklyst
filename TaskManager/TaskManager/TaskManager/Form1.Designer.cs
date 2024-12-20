namespace TaskManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            sidebarMenu = new FlowLayoutPanel();
            panel3 = new Panel();
            btnSidebar = new Button();
            pnlDashboard = new Panel();
            btnDashboard = new Button();
            pnlProjects = new FlowLayoutPanel();
            panel2 = new Panel();
            btnProjects = new Button();
            panel5 = new Panel();
            btnProject1 = new Button();
            pnlSettings = new Panel();
            btnSettings = new Button();
            menuDropdown = new System.Windows.Forms.Timer(components);
            sidebarDropdown = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            sidebarMenu.SuspendLayout();
            panel3.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlProjects.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            pnlSettings.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarMenu
            // 
            sidebarMenu.BackColor = Color.FromArgb(32, 31, 48);
            sidebarMenu.Controls.Add(panel3);
            sidebarMenu.Controls.Add(pnlDashboard);
            sidebarMenu.Controls.Add(pnlProjects);
            sidebarMenu.Controls.Add(pnlSettings);
            sidebarMenu.Dock = DockStyle.Left;
            sidebarMenu.FlowDirection = FlowDirection.TopDown;
            sidebarMenu.Location = new Point(0, 0);
            sidebarMenu.Name = "sidebarMenu";
            sidebarMenu.Size = new Size(360, 872);
            sidebarMenu.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSidebar);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(363, 83);
            panel3.TabIndex = 3;
            // 
            // btnSidebar
            // 
            btnSidebar.BackColor = Color.FromArgb(32, 31, 48);
            btnSidebar.Font = new Font("Segoe UI Light", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSidebar.ForeColor = Color.White;
            btnSidebar.Image = (Image)resources.GetObject("btnSidebar.Image");
            btnSidebar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSidebar.Location = new Point(-9, -19);
            btnSidebar.Name = "btnSidebar";
            btnSidebar.Padding = new Padding(30, 0, 0, 0);
            btnSidebar.Size = new Size(383, 121);
            btnSidebar.TabIndex = 1;
            btnSidebar.Text = "         Tasklyst";
            btnSidebar.TextAlign = ContentAlignment.MiddleLeft;
            btnSidebar.UseVisualStyleBackColor = false;
            btnSidebar.Click += btnSidebar_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(btnDashboard);
            pnlDashboard.Location = new Point(3, 92);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(363, 83);
            pnlDashboard.TabIndex = 1;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(32, 31, 48);
            btnDashboard.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(-9, -19);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(30, 0, 0, 0);
            btnDashboard.Size = new Size(383, 121);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "         Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click_1;
            btnDashboard.MouseEnter += btnDashboard_MouseEnter;
            btnDashboard.MouseLeave += btnDashboard_MouseLeave;
            // 
            // pnlProjects
            // 
            pnlProjects.BackColor = Color.FromArgb(32, 31, 48);
            pnlProjects.Controls.Add(panel2);
            pnlProjects.Controls.Add(panel5);
            pnlProjects.Location = new Point(0, 178);
            pnlProjects.Margin = new Padding(0);
            pnlProjects.Name = "pnlProjects";
            pnlProjects.Size = new Size(363, 83);
            pnlProjects.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnProjects);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(363, 83);
            panel2.TabIndex = 2;
            // 
            // btnProjects
            // 
            btnProjects.BackColor = Color.FromArgb(32, 31, 48);
            btnProjects.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProjects.ForeColor = Color.White;
            btnProjects.Image = (Image)resources.GetObject("btnProjects.Image");
            btnProjects.ImageAlign = ContentAlignment.MiddleLeft;
            btnProjects.Location = new Point(-9, -19);
            btnProjects.Name = "btnProjects";
            btnProjects.Padding = new Padding(30, 0, 0, 0);
            btnProjects.Size = new Size(383, 121);
            btnProjects.TabIndex = 1;
            btnProjects.Text = "         Resources";
            btnProjects.TextAlign = ContentAlignment.MiddleLeft;
            btnProjects.UseVisualStyleBackColor = false;
            btnProjects.Click += menu_Click;
            btnProjects.MouseEnter += btnProjects_MouseEnter;
            btnProjects.MouseLeave += btnProjects_MouseLeave;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnProject1);
            panel5.Location = new Point(3, 92);
            panel5.Name = "panel5";
            panel5.Size = new Size(363, 83);
            panel5.TabIndex = 4;
            // 
            // btnProject1
            // 
            btnProject1.BackColor = Color.FromArgb(32, 31, 48);
            btnProject1.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProject1.ForeColor = Color.White;
            btnProject1.Image = (Image)resources.GetObject("btnProject1.Image");
            btnProject1.ImageAlign = ContentAlignment.MiddleLeft;
            btnProject1.Location = new Point(-9, -19);
            btnProject1.Name = "btnProject1";
            btnProject1.Padding = new Padding(80, 0, 0, 0);
            btnProject1.Size = new Size(383, 121);
            btnProject1.TabIndex = 1;
            btnProject1.Text = "         Your Tasks";
            btnProject1.TextAlign = ContentAlignment.MiddleLeft;
            btnProject1.UseVisualStyleBackColor = false;
            btnProject1.Click += btnProject1_Click;
            btnProject1.MouseEnter += btnProject1_MouseEnter;
            btnProject1.MouseLeave += btnProject1_MouseLeave;
            // 
            // pnlSettings
            // 
            pnlSettings.Controls.Add(btnSettings);
            pnlSettings.Location = new Point(3, 264);
            pnlSettings.Name = "pnlSettings";
            pnlSettings.Size = new Size(363, 83);
            pnlSettings.TabIndex = 5;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(32, 31, 48);
            btnSettings.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(-9, -19);
            btnSettings.Name = "btnSettings";
            btnSettings.Padding = new Padding(30, 0, 0, 0);
            btnSettings.Size = new Size(383, 121);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "         Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            btnSettings.MouseEnter += btnSettings_MouseEnter;
            btnSettings.MouseLeave += btnSettings_MouseLeave;
            // 
            // menuDropdown
            // 
            menuDropdown.Interval = 10;
            menuDropdown.Tick += menuDropdown_Tick;
            // 
            // sidebarDropdown
            // 
            sidebarDropdown.Interval = 10;
            sidebarDropdown.Tick += sideDropdown_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(32, 31, 48);
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(360, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1126, 48);
            panel1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1486, 872);
            Controls.Add(panel1);
            Controls.Add(sidebarMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            sidebarMenu.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pnlDashboard.ResumeLayout(false);
            pnlProjects.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            pnlSettings.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebarMenu;
        private Button btnDashboard;
        private Panel pnlDashboard;
        private Panel panel3;
        private Button btnSidebar;
        private System.Windows.Forms.Timer menuDropdown;
        private System.Windows.Forms.Timer sidebarDropdown;
        private Panel panel1;
        private Button btnSettings;
        private Panel pnlSettings;
        private Panel panel5;
        private Button btnProject1;
        private Panel panel2;
        private Button btnProjects;
        private FlowLayoutPanel pnlProjects;
    }
}
