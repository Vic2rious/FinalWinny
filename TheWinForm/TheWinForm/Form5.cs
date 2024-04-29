using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TheWinForm.authentication;
using System.Diagnostics;


namespace TheWinForm
{
    public partial class Form5 : Form
    {
        Order theOrder;
        string rating;
        public Form5(Order order)
        {
            InitializeComponent();
            this.theOrder = order;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public string RateSelection()
        {
            return radioButton1.Checked ? radioButton1.Text :
            radioButton2.Checked ? radioButton2.Text :
            radioButton3.Checked ? radioButton3.Text :
            radioButton4.Checked ? radioButton4.Text :
            radioButton5.Checked ? radioButton5.Text :
            string.Empty;

        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            rating = RateSelection();

            theOrder.setRating(rating);



            if (BonusCheckBox.Checked)
            {
                new Form2(theOrder.User).Show();
            }
            else
            {
                Application.Exit();
            }

        }
    }
}
