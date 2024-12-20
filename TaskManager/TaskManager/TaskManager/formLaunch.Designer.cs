namespace TaskManager
{
    partial class formLaunch
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
            button1 = new Button();
            label1 = new Label();
            lblConfirm = new Label();
            SuspendLayout();
            // 
            // lblLaunchTitle
            // 
            lblLaunchTitle.AutoSize = true;
            lblLaunchTitle.Font = new Font("Segoe UI Semibold", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLaunchTitle.Location = new Point(313, 69);
            lblLaunchTitle.Name = "lblLaunchTitle";
            lblLaunchTitle.Size = new Size(484, 86);
            lblLaunchTitle.TabIndex = 0;
            lblLaunchTitle.Text = "Getting Started";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(368, 272);
            button1.Name = "button1";
            button1.Size = new Size(374, 115);
            button1.TabIndex = 1;
            button1.Text = "Create Task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(323, 191);
            label1.Name = "label1";
            label1.Size = new Size(464, 47);
            label1.TabIndex = 2;
            label1.Text = "Work Smarter With Tasklyte";
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.ForeColor = Color.FromArgb(59, 58, 85);
            lblConfirm.Location = new Point(1302, 684);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(38, 15);
            lblConfirm.TabIndex = 3;
            lblConfirm.Text = "label2";
            // 
            // formLaunch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(59, 58, 85);
            ClientSize = new Size(1440, 800);
            Controls.Add(lblConfirm);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lblLaunchTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formLaunch";
            Text = "formLaunch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLaunchTitle;
        private Button button1;
        private Label label1;
        private Label lblConfirm;
    }
}