namespace TaskManager
{
    partial class formDashboard
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
            lblLaunchTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblLaunchTitle
            // 
            lblLaunchTitle.AutoSize = true;
            lblLaunchTitle.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLaunchTitle.Location = new Point(12, 9);
            lblLaunchTitle.Name = "lblLaunchTitle";
            lblLaunchTitle.Size = new Size(362, 86);
            lblLaunchTitle.TabIndex = 1;
            lblLaunchTitle.Text = "Dashboard";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 107);
            label1.Name = "label1";
            label1.Size = new Size(652, 45);
            label1.TabIndex = 2;
            label1.Text = "Here you can see stats on your current tasks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 169);
            label2.Name = "label2";
            label2.Size = new Size(861, 45);
            label2.TabIndex = 3;
            label2.Text = "Your Projects can be found under resources on the sidebar.";
            // 
            // formDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(59, 58, 85);
            ClientSize = new Size(1424, 761);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblLaunchTitle);
            Name = "formDashboard";
            Text = "formDashboard";
            Load += formDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLaunchTitle;
        private Label label1;
        private Label label2;
    }
}