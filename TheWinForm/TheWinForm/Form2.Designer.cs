namespace TheWinForm
{
    partial class Form2
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
            usernameLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            uploadBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.Dock = DockStyle.Fill;
            usernameLabel.FlatStyle = FlatStyle.Flat;
            usernameLabel.Font = new Font("Impact", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            usernameLabel.ForeColor = Color.Fuchsia;
            usernameLabel.Location = new Point(0, 0);
            usernameLabel.Margin = new Padding(0, 0, 3, 0);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(800, 603);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Welcome";
            usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
            usernameLabel.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // uploadBtn
            // 
            uploadBtn.BackColor = Color.Fuchsia;
            uploadBtn.Dock = DockStyle.Bottom;
            uploadBtn.FlatAppearance.BorderSize = 0;
            uploadBtn.FlatStyle = FlatStyle.Flat;
            uploadBtn.Font = new Font("Microsoft YaHei", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            uploadBtn.ForeColor = Color.Lime;
            uploadBtn.Location = new Point(0, 535);
            uploadBtn.Name = "uploadBtn";
            uploadBtn.Size = new Size(800, 68);
            uploadBtn.TabIndex = 4;
            uploadBtn.Text = "Upload Photo";
            uploadBtn.UseVisualStyleBackColor = false;
            uploadBtn.Click += uploadBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(800, 603);
            Controls.Add(uploadBtn);
            Controls.Add(pictureBox1);
            Controls.Add(usernameLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label usernameLabel;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private Button uploadBtn;
    }
}