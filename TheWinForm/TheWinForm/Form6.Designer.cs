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
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft YaHei", 36.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(162, 19);
            label1.Name = "label1";
            label1.Size = new Size(505, 65);
            label1.TabIndex = 0;
            label1.Text = "Taxi is on your way";
            label1.Click += label1_Click;
            // 
            // timeLeftLabel
            // 
            timeLeftLabel.AutoSize = true;
            timeLeftLabel.BackColor = Color.Transparent;
            timeLeftLabel.Font = new Font("Microsoft YaHei", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            timeLeftLabel.ForeColor = Color.Red;
            timeLeftLabel.Location = new Point(456, 84);
            timeLeftLabel.Name = "timeLeftLabel";
            timeLeftLabel.Size = new Size(175, 46);
            timeLeftLabel.TabIndex = 0;
            timeLeftLabel.Text = "Time left";
            timeLeftLabel.Click += timeLeftLabel_Click;
            // 
            // time
            // 
            time.AutoSize = true;
            time.BackColor = Color.Transparent;
            time.Font = new Font("Microsoft YaHei", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            time.ForeColor = Color.Red;
            time.Location = new Point(447, 146);
            time.Name = "time";
            time.Size = new Size(54, 46);
            time.TabIndex = 0;
            time.Text = "m";
            time.Click += time_Click;
            // 
            // DriverName
            // 
            DriverName.AutoSize = true;
            DriverName.BackColor = Color.Transparent;
            DriverName.Font = new Font("Microsoft YaHei", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            DriverName.ForeColor = Color.Red;
            DriverName.Location = new Point(456, 190);
            DriverName.Name = "DriverName";
            DriverName.Size = new Size(128, 46);
            DriverName.TabIndex = 0;
            DriverName.Text = "Driver";
            // 
            // licensePlate
            // 
            licensePlate.AutoSize = true;
            licensePlate.BackColor = Color.Transparent;
            licensePlate.Font = new Font("Microsoft YaHei", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            licensePlate.ForeColor = Color.Red;
            licensePlate.Location = new Point(456, 234);
            licensePlate.Name = "licensePlate";
            licensePlate.Size = new Size(245, 46);
            licensePlate.TabIndex = 0;
            licensePlate.Text = "License Plate";
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Transparent;
            cancelButton.ForeColor = Color.Red;
            cancelButton.Location = new Point(283, 350);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Transparent;
            ExitButton.ForeColor = Color.Red;
            ExitButton.Location = new Point(431, 350);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
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
            seconds.BackColor = Color.Transparent;
            seconds.Font = new Font("Microsoft YaHei", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            seconds.ForeColor = Color.Red;
            seconds.Location = new Point(547, 146);
            seconds.Name = "seconds";
            seconds.Size = new Size(37, 46);
            seconds.TabIndex = 0;
            seconds.Text = "s";
            seconds.Click += time_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_vibrant_3d_yellow_taxi_symbol_with_map_pointer_convenient_app_for_image_3650810;
            ClientSize = new Size(800, 379);
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