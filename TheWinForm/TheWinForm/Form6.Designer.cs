namespace TheWinForm
{
    partial class Form6
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timeLeftLabel = new Label();
            time = new Label();
            DriverName = new Label();
            licensePlate = new Label();
            cancelButton = new Button();
            ExitButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            seconds = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 45);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Taxi is on your way";
            label1.Click += label1_Click;
            // 
            // timeLeftLabel
            // 
            timeLeftLabel.AutoSize = true;
            timeLeftLabel.Location = new Point(292, 106);
            timeLeftLabel.Name = "timeLeftLabel";
            timeLeftLabel.Size = new Size(53, 15);
            timeLeftLabel.TabIndex = 0;
            timeLeftLabel.Text = "Time left";
            // 
            // time
            // 
            time.AutoSize = true;
            time.Location = new Point(292, 142);
            time.Name = "time";
            time.Size = new Size(18, 15);
            time.TabIndex = 0;
            time.Text = "m";
            time.Click += time_Click;
            // 
            // DriverName
            // 
            DriverName.AutoSize = true;
            DriverName.Location = new Point(292, 212);
            DriverName.Name = "DriverName";
            DriverName.Size = new Size(38, 15);
            DriverName.TabIndex = 0;
            DriverName.Text = "Driver";
            // 
            // licensePlate
            // 
            licensePlate.AutoSize = true;
            licensePlate.Location = new Point(292, 256);
            licensePlate.Name = "licensePlate";
            licensePlate.Size = new Size(75, 15);
            licensePlate.TabIndex = 0;
            licensePlate.Text = "License Plate";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(283, 350);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(431, 350);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // seconds
            // 
            seconds.AutoSize = true;
            seconds.Location = new Point(318, 142);
            seconds.Name = "seconds";
            seconds.Size = new Size(12, 15);
            seconds.TabIndex = 0;
            seconds.Text = "s";
            seconds.Click += time_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ExitButton);
            Controls.Add(cancelButton);
            Controls.Add(licensePlate);
            Controls.Add(DriverName);
            Controls.Add(seconds);
            Controls.Add(time);
            Controls.Add(timeLeftLabel);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label timeLeftLabel;
        private Label time;
        private Label DriverName;
        private Label licensePlate;
        private Button cancelButton;
        private Button ExitButton;
        private System.Windows.Forms.Timer timer1;
        private Label seconds;
    }
}