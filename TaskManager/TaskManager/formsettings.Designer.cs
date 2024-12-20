namespace TaskManager
{
    partial class formsettings
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
            button2 = new Button();
            rtbSaveData = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // lblLaunchTitle
            // 
            lblLaunchTitle.AutoSize = true;
            lblLaunchTitle.Font = new Font("Segoe UI Semibold", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblLaunchTitle.Location = new Point(276, 9);
            lblLaunchTitle.Name = "lblLaunchTitle";
            lblLaunchTitle.Size = new Size(398, 128);
            lblLaunchTitle.TabIndex = 3;
            lblLaunchTitle.Text = "Settings";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(352, 160);
            button1.Name = "button1";
            button1.Size = new Size(222, 45);
            button1.TabIndex = 5;
            button1.Text = "Delete Data";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(352, 248);
            button2.Name = "button2";
            button2.Size = new Size(222, 45);
            button2.TabIndex = 6;
            button2.Text = "Overwrite";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // rtbSaveData
            // 
            rtbSaveData.Location = new Point(150, 347);
            rtbSaveData.Name = "rtbSaveData";
            rtbSaveData.Size = new Size(665, 342);
            rtbSaveData.TabIndex = 7;
            rtbSaveData.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(108, 296);
            label1.Name = "label1";
            label1.Size = new Size(738, 32);
            label1.TabIndex = 8;
            label1.Text = "WARNING: If not formatted correctly, could break the program";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(168, 213);
            label2.Name = "label2";
            label2.Size = new Size(602, 32);
            label2.TabIndex = 9;
            label2.Text = "WARNING: Resets save file. This includes metadata.";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(400, 705);
            button3.Name = "button3";
            button3.Size = new Size(129, 44);
            button3.TabIndex = 10;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // formsettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(59, 58, 85);
            ClientSize = new Size(1424, 761);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtbSaveData);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblLaunchTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formsettings";
            Text = "formsettings";
            Load += formsettings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLaunchTitle;
        private Button button1;
        private Button button2;
        private RichTextBox rtbSaveData;
        private Label label1;
        private Label label2;
        private Button button3;
    }
}