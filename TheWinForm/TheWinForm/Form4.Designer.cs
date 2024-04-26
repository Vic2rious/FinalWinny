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
            radioButton1.Location = new Point(271, 45);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "budget";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(271, 70);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(62, 19);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "regular";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(271, 95);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(77, 19);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "expensive";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(271, 120);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(74, 19);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "luxurious";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(271, 145);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(44, 19);
            radioButton5.TabIndex = 0;
            radioButton5.TabStop = true;
            radioButton5.Text = "eco";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // startDestination
            // 
            startDestination.Location = new Point(283, 226);
            startDestination.Name = "startDestination";
            startDestination.PlaceholderText = "Starting Destination";
            startDestination.Size = new Size(152, 23);
            startDestination.TabIndex = 1;
            startDestination.Validating += startDestination_Validating;
            // 
            // endDestination
            // 
            endDestination.Location = new Point(283, 287);
            endDestination.Name = "endDestination";
            endDestination.PlaceholderText = "End destination";
            endDestination.Size = new Size(152, 23);
            endDestination.TabIndex = 2;
            endDestination.Validating += endDestination_Validating;
            // 
            // myLocationButton
            // 
            myLocationButton.Location = new Point(476, 226);
            myLocationButton.Name = "myLocationButton";
            myLocationButton.Size = new Size(139, 23);
            myLocationButton.TabIndex = 3;
            myLocationButton.Text = "Choose my location";
            myLocationButton.UseVisualStyleBackColor = true;
            myLocationButton.Click += myLocationButton_Click;
            // 
            // orderButton
            // 
            orderButton.Location = new Point(326, 352);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(75, 23);
            orderButton.TabIndex = 4;
            orderButton.Text = "Order";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(493, 352);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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