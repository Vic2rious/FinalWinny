namespace TheWinForm
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
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            button1 = new Button();
            label2 = new Label();
            uNameTxt = new TextBox();
            txtpassword = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label3 = new Label();
            pictureBox4 = new PictureBox();
            panel6 = new Panel();
            emailTxt = new TextBox();
            length = new Label();
            capital = new Label();
            lowercase = new Label();
            number = new Label();
            comboBox1 = new ComboBox();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.User_icon_cp_svg;
            pictureBox2.Location = new Point(24, 72);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 103);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(144, 165);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 1);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Location = new Point(147, 165);
            panel2.Name = "panel2";
            panel2.Size = new Size(281, 1);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Location = new Point(181, 174);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 1);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Fuchsia;
            panel4.Location = new Point(24, 181);
            panel4.Name = "panel4";
            panel4.Size = new Size(449, 10);
            panel4.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._2889676;
            pictureBox3.Location = new Point(24, 360);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(101, 103);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Fuchsia;
            panel5.Location = new Point(24, 469);
            panel5.Name = "panel5";
            panel5.Size = new Size(449, 10);
            panel5.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Fuchsia;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft YaHei", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(12, 876);
            button1.Name = "button1";
            button1.Size = new Size(206, 64);
            button1.TabIndex = 7;
            button1.Text = "REGISTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(379, 493);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 8;
            label2.Text = "Clear Fields";
            label2.Click += label2_Click;
            // 
            // uNameTxt
            // 
            uNameTxt.BackColor = Color.Fuchsia;
            uNameTxt.BorderStyle = BorderStyle.None;
            uNameTxt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            uNameTxt.Location = new Point(144, 152);
            uNameTxt.Multiline = true;
            uNameTxt.Name = "uNameTxt";
            uNameTxt.PlaceholderText = "username";
            uNameTxt.Size = new Size(312, 23);
            uNameTxt.TabIndex = 9;
            uNameTxt.TextChanged += uNameTxt_TextChanged;
            uNameTxt.Validating += txtUserName_Validating;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.Fuchsia;
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtpassword.Location = new Point(144, 440);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.PlaceholderText = "password";
            txtpassword.Size = new Size(312, 23);
            txtpassword.TabIndex = 9;
            txtpassword.TextChanged += txtpassword_TextChanged;
            txtpassword.Validating += txtpassword_Validating;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(196, 943);
            label3.Name = "label3";
            label3.Size = new Size(98, 51);
            label3.TabIndex = 11;
            label3.Text = "EXIT";
            label3.Click += label3_Click_1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.mail;
            pictureBox4.Location = new Point(24, 220);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(101, 103);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Fuchsia;
            panel6.Location = new Point(24, 329);
            panel6.Name = "panel6";
            panel6.Size = new Size(449, 10);
            panel6.TabIndex = 6;
            // 
            // emailTxt
            // 
            emailTxt.BackColor = Color.Fuchsia;
            emailTxt.BorderStyle = BorderStyle.None;
            emailTxt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            emailTxt.Location = new Point(144, 300);
            emailTxt.Multiline = true;
            emailTxt.Name = "emailTxt";
            emailTxt.PlaceholderText = "email";
            emailTxt.Size = new Size(312, 23);
            emailTxt.TabIndex = 9;
            emailTxt.TextChanged += textBox1_TextChanged;
            emailTxt.Validating += textBox1_Validating;
            // 
            // length
            // 
            length.AutoSize = true;
            length.Font = new Font("Lucida Console", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            length.Location = new Point(147, 360);
            length.Name = "length";
            length.Size = new Size(127, 15);
            length.TabIndex = 12;
            length.Text = "8 characters";
            length.Click += length_Click;
            // 
            // capital
            // 
            capital.AutoSize = true;
            capital.Font = new Font("Lucida Console", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            capital.Location = new Point(147, 375);
            capital.Name = "capital";
            capital.Size = new Size(187, 15);
            capital.TabIndex = 12;
            capital.Text = "One capital letter";
            capital.Click += capital_Click;
            // 
            // lowercase
            // 
            lowercase.AutoSize = true;
            lowercase.Font = new Font("Lucida Console", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lowercase.Location = new Point(147, 405);
            lowercase.Name = "lowercase";
            lowercase.Size = new Size(207, 15);
            lowercase.TabIndex = 12;
            lowercase.Text = "One lowercase letter";
            lowercase.Click += lowercase_Click;
            // 
            // number
            // 
            number.AutoSize = true;
            number.Font = new Font("Lucida Console", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            number.Location = new Point(147, 390);
            number.Name = "number";
            number.Size = new Size(107, 15);
            number.TabIndex = 12;
            number.Text = "One number";
            number.Click += number_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Lime;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.Fuchsia;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "- Male", "- Female", "- Abinary", "- Agender", "- Ambigender", "- Androgyne", "- Androgynous", "- Aporagender", "- Autigender", "- Bakla", "- Bigender", "- Binary", "- Bissu", "- Butch", "- Calabai", "- Calalai", "- Cis", "- Cisgender", "- Cis female", "- Cis male", "- Cis man", "- Cis woman", "- Demi-boy", "- Demiflux", "- Demigender", "- Demi-girl", "- Demi-guy", "- Demi-man", "- Demi-woman", "- Dual gender", "- Faʻafafine", "- Female to male", "- Femme", "- FTM", "- Gender bender", "- Gender diverse", "- Gender gifted", "- Genderfae", "- Genderfluid", "- Genderflux", "- Genderfuck", "- Genderless", "- Gender nonconforming", "- Genderqueer", "- Gender questioning", "- Gender variant", "- Graygender", "- Hijra", "- Intergender", "- Intersex", "- Kathoey", "- Māhū", "- Male to female", "- Man", "- Man of trans experience", "- Maverique", "- Meta-gender", "- MTF", "- Multigender", "- Muxe", "- Neither", "- Neurogender", "- Neutrois", "- Non-binary", "- Non-binary transgender", "- Omnigender", "- Other", "- Pangender", "- Person of transgendered experience", "- Polygender", "- Sekhet", "- Third gender", "- Trans", "- Trans*", "- Trans female", "- Trans male", "- Trans man", "- Trans person", "- Trans woman", "- Transgender", "- Transgender female", "- Transgender male", "- Transgender man", "- Transgender person", "- Transgender woman", "- Transfeminine", "- Transmasculine", "- Transsexual", "- Transsexual female", "- Transsexual male", "- Transsexual man", "- Transsexual person", "- Transsexual woman", "- Travesti", "- Trigender", "- Tumtum", "- Two spirit", "- Vakasalewalewa", "- Waria", "- Winkte", "- Woman", "- Woman of trans experience", "- X-gender", "- X-jendā", "- Xenogender" });
            comboBox1.Location = new Point(24, 493);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 29);
            comboBox1.TabIndex = 13;
            comboBox1.Tag = "";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = Color.Fuchsia;
            button2.Location = new Point(244, 485);
            button2.Name = "button2";
            button2.Size = new Size(113, 37);
            button2.TabIndex = 15;
            button2.Text = "Theme?";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Fuchsia;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft YaHei", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = Color.Lime;
            button3.Location = new Point(279, 876);
            button3.Name = "button3";
            button3.Size = new Size(206, 64);
            button3.TabIndex = 16;
            button3.Text = "LOGIN";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngimg_com___taxi_logos_PNG12;
            pictureBox1.Location = new Point(24, 589);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(461, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LawnGreen;
            ClientSize = new Size(510, 1060);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(number);
            Controls.Add(lowercase);
            Controls.Add(capital);
            Controls.Add(length);
            Controls.Add(label3);
            Controls.Add(txtpassword);
            Controls.Add(emailTxt);
            Controls.Add(uNameTxt);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Panel panel5;
        private Button button1;
        private Label label2;
        private TextBox uNameTxt;
        private TextBox txtpassword;
        private ContextMenuStrip contextMenuStrip1;
        private Label label3;
        private PictureBox pictureBox4;
        private Panel panel6;
        private TextBox emailTxt;
        private Label length;
        private Label capital;
        private Label lowercase;
        private Label number;
        private ComboBox comboBox1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
    }
}