namespace TheWinForm
{
    partial class Form5
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
            finishButton = new Button();
            rateLabel = new Label();
            BonusCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(299, 62);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Very poor";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(299, 87);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(50, 19);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "Poor";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(299, 112);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(44, 19);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "Fair";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(299, 137);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(54, 19);
            radioButton4.TabIndex = 0;
            radioButton4.TabStop = true;
            radioButton4.Text = "Good";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(299, 162);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(72, 19);
            radioButton5.TabIndex = 0;
            radioButton5.TabStop = true;
            radioButton5.Text = "Excellent";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // finishButton
            // 
            finishButton.Location = new Point(296, 291);
            finishButton.Name = "finishButton";
            finishButton.Size = new Size(75, 23);
            finishButton.TabIndex = 1;
            finishButton.Text = "Finish";
            finishButton.UseVisualStyleBackColor = true;
            finishButton.Click += finishButton_Click;
            // 
            // rateLabel
            // 
            rateLabel.AutoSize = true;
            rateLabel.Location = new Point(296, 24);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new Size(81, 15);
            rateLabel.TabIndex = 2;
            rateLabel.Text = "Please rate us!";
            // 
            // BonusCheckBox
            // 
            BonusCheckBox.AutoSize = true;
            BonusCheckBox.Location = new Point(406, 295);
            BonusCheckBox.Name = "BonusCheckBox";
            BonusCheckBox.Size = new Size(59, 19);
            BonusCheckBox.TabIndex = 3;
            BonusCheckBox.Text = "Bonus";
            BonusCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BonusCheckBox);
            Controls.Add(rateLabel);
            Controls.Add(finishButton);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private Button finishButton;
        private Label rateLabel;
        private CheckBox BonusCheckBox;
    }
}