namespace TaskManager
{
    partial class formProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formProject));
            lblLaunchTitle = new Label();
            dgvTasks = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // lblLaunchTitle
            // 
            lblLaunchTitle.AutoSize = true;
            lblLaunchTitle.Font = new Font("Segoe UI", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLaunchTitle.Location = new Point(12, 20);
            lblLaunchTitle.Name = "lblLaunchTitle";
            lblLaunchTitle.Size = new Size(423, 128);
            lblLaunchTitle.TabIndex = 2;
            lblLaunchTitle.Text = "Tasklyst";
            // 
            // dgvTasks
            // 
            dgvTasks.AllowUserToAddRows = false;
            dgvTasks.AllowUserToDeleteRows = false;
            dgvTasks.AllowUserToResizeColumns = false;
            dgvTasks.AllowUserToResizeRows = false;
            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTasks.BackgroundColor = Color.MediumSlateBlue;
            dgvTasks.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvTasks.DefaultCellStyle = dataGridViewCellStyle1;
            dgvTasks.Dock = DockStyle.Bottom;
            dgvTasks.Location = new Point(0, 247);
            dgvTasks.MultiSelect = false;
            dgvTasks.Name = "dgvTasks";
            dgvTasks.ReadOnly = true;
            dgvTasks.RowHeadersVisible = false;
            dgvTasks.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvTasks.Size = new Size(1424, 514);
            dgvTasks.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(506, 123);
            button1.Name = "button1";
            button1.Size = new Size(222, 45);
            button1.TabIndex = 4;
            button1.Text = "Create new task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(838, 123);
            button2.Name = "button2";
            button2.Size = new Size(222, 45);
            button2.TabIndex = 5;
            button2.Text = "Refresh Tasks";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 148);
            label1.Name = "label1";
            label1.Size = new Size(287, 20);
            label1.TabIndex = 6;
            label1.Text = "Tasks now easier to manage than ever!";
            // 
            // formProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(59, 58, 85);
            ClientSize = new Size(1424, 761);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgvTasks);
            Controls.Add(lblLaunchTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formProject";
            Text = resources.GetString("$this.Text");
            Load += formProject_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLaunchTitle;
        private DataGridView dgvTasks;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}