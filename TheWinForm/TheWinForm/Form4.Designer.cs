namespace TheWinForm
{
    partial class Form4
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            startDestination = new TextBox();
            endDestination = new TextBox();
            myLocationButton = new Button();
            orderButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.ForeColor = Color.Red;
            radioButton1.Location = new Point(476, 71);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "budget";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.ForeColor = Color.Red;
            radioButton2.Location = new Point(476, 96);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(62, 19);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "regular";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Transparent;
            radioButton3.ForeColor = Color.Red;
            radioButton3.Location = new Point(476, 121);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(77, 19);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "expensive";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = Color.Transparent;
            radioButton4.ForeColor = Color.Red;
            radioButton4.Location = new Point(476, 146);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(74, 19);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "luxurious";
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.BackColor = Color.Transparent;
            radioButton5.ForeColor = Color.Red;
            radioButton5.Location = new Point(476, 171);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(44, 19);
            radioButton5.TabIndex = 0;
            radioButton5.TabStop = true;
            radioButton5.Text = "eco";
            radioButton5.UseVisualStyleBackColor = false;
            // 
            // startDestination
            // 
            startDestination.ForeColor = Color.Red;
            startDestination.Location = new Point(283, 226);
            startDestination.Name = "startDestination";
            startDestination.PlaceholderText = "Starting Destination";
            startDestination.Size = new Size(152, 23);
            startDestination.TabIndex = 1;
            startDestination.Validating += startDestination_Validating;
            // 
            // endDestination
            // 
            endDestination.ForeColor = Color.Red;
            endDestination.Location = new Point(283, 287);
            endDestination.Name = "endDestination";
            endDestination.PlaceholderText = "End destination";
            endDestination.Size = new Size(152, 23);
            endDestination.TabIndex = 2;
            endDestination.Validating += endDestination_Validating;
            // 
            // myLocationButton
            // 
            myLocationButton.BackColor = Color.Transparent;
            myLocationButton.ForeColor = Color.Red;
            myLocationButton.Location = new Point(476, 226);
            myLocationButton.Name = "myLocationButton";
            myLocationButton.Size = new Size(139, 23);
            myLocationButton.TabIndex = 3;
            myLocationButton.Text = "Choose my location";
            myLocationButton.UseVisualStyleBackColor = false;
            myLocationButton.Click += myLocationButton_Click;
            // 
            // orderButton
            // 
            orderButton.BackColor = Color.Transparent;
            orderButton.ForeColor = Color.Red;
            orderButton.Location = new Point(326, 352);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(75, 23);
            orderButton.TabIndex = 4;
            orderButton.Text = "Order";
            orderButton.UseVisualStyleBackColor = false;
            orderButton.Click += orderButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Transparent;
            ExitButton.ForeColor = Color.Red;
            ExitButton.Location = new Point(493, 352);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pngtree_vibrant_3d_yellow_taxi_symbol_with_map_pointer_convenient_app_for_image_3650810;
            ClientSize = new Size(800, 391);
            Controls.Add(ExitButton);
            Controls.Add(orderButton);
            Controls.Add(myLocationButton);
            Controls.Add(endDestination);
            Controls.Add(startDestination);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private TextBox startDestination;
        private TextBox endDestination;
        private Button myLocationButton;
        private Button orderButton;
        private Button ExitButton;
    }
}