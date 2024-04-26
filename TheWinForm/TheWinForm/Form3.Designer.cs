namespace TheWinForm
{
    partial class Form3
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
            button1 = new Button();
            username = new TextBox();
            password = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Fuchsia;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft YaHei", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(293, 318);
            button1.Name = "button1";
            button1.Size = new Size(127, 81);
            button1.TabIndex = 0;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // username
            // 
            username.Location = new Point(263, 92);
            username.Name = "username";
            username.PlaceholderText = "username";
            username.Size = new Size(192, 23);
            username.TabIndex = 1;
            username.TextChanged += username_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(263, 149);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "password";
            password.Size = new Size(192, 23);
            password.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.Fuchsia;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft YaHei", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = Color.Lime;
            button2.Location = new Point(276, 230);
            button2.Name = "button2";
            button2.Size = new Size(166, 59);
            button2.TabIndex = 2;
            button2.Text = "LOGIN";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = Color.Fuchsia;
            button3.Location = new Point(302, 29);
            button3.Name = "button3";
            button3.Size = new Size(101, 37);
            button3.TabIndex = 3;
            button3.Text = "Theme";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lime;
            ClientSize = new Size(725, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox username;
        private TextBox password;
        private Button button2;
        private Button button3;
    }
}