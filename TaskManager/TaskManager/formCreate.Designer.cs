namespace TaskManager
{
    partial class formCreate
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
            tbTask = new TextBox();
            tbName = new TextBox();
            dtpDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            rbStuck = new RadioButton();
            rbWorking = new RadioButton();
            SuspendLayout();
            // 
            // lblLaunchTitle
            // 
            lblLaunchTitle.AutoSize = true;
            lblLaunchTitle.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLaunchTitle.Location = new Point(97, 24);
            lblLaunchTitle.Name = "lblLaunchTitle";
            lblLaunchTitle.Size = new Size(319, 65);
            lblLaunchTitle.TabIndex = 1;
            lblLaunchTitle.Text = "Task Creation";
            // 
            // tbTask
            // 
            tbTask.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTask.Location = new Point(97, 149);
            tbTask.Name = "tbTask";
            tbTask.Size = new Size(319, 50);
            tbTask.TabIndex = 2;
            tbTask.TextAlign = HorizontalAlignment.Center;
            // 
            // tbName
            // 
            tbName.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbName.Location = new Point(97, 263);
            tbName.Name = "tbName";
            tbName.Size = new Size(319, 50);
            tbName.TabIndex = 3;
            tbName.TextAlign = HorizontalAlignment.Center;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(96, 533);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(319, 23);
            dtpDate.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(153, 104);
            label1.Name = "label1";
            label1.Size = new Size(206, 32);
            label1.TabIndex = 7;
            label1.Text = "What's The Task?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(162, 230);
            label2.Name = "label2";
            label2.Size = new Size(0, 30);
            label2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(140, 219);
            label3.Name = "label3";
            label3.Size = new Size(236, 32);
            label3.TabIndex = 9;
            label3.Text = "What's Your Name?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(163, 333);
            label4.Name = "label4";
            label4.Size = new Size(182, 32);
            label4.TabIndex = 10;
            label4.Text = "Project Status?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(140, 476);
            label5.Name = "label5";
            label5.Size = new Size(230, 32);
            label5.TabIndex = 11;
            label5.Text = "Choose a deadline!";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(92, 610);
            button1.Name = "button1";
            button1.Size = new Size(333, 78);
            button1.TabIndex = 12;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rbStuck
            // 
            rbStuck.AutoSize = true;
            rbStuck.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbStuck.Location = new Point(112, 402);
            rbStuck.Name = "rbStuck";
            rbStuck.Size = new Size(89, 36);
            rbStuck.TabIndex = 14;
            rbStuck.TabStop = true;
            rbStuck.Text = "Stuck";
            rbStuck.UseVisualStyleBackColor = true;
            // 
            // rbWorking
            // 
            rbWorking.AutoSize = true;
            rbWorking.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbWorking.Location = new Point(207, 402);
            rbWorking.Name = "rbWorking";
            rbWorking.Size = new Size(181, 36);
            rbWorking.TabIndex = 15;
            rbWorking.TabStop = true;
            rbWorking.Text = "Working On It";
            rbWorking.UseVisualStyleBackColor = true;
            // 
            // formCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 64);
            ClientSize = new Size(524, 761);
            Controls.Add(rbWorking);
            Controls.Add(rbStuck);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpDate);
            Controls.Add(tbName);
            Controls.Add(tbTask);
            Controls.Add(lblLaunchTitle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "formCreate";
            Text = "formCreate";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLaunchTitle;
        private TextBox tbTask;
        private TextBox tbName;
        private DateTimePicker dtpDate;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private RadioButton rbStuck;
        private RadioButton rbWorking;
    }
}