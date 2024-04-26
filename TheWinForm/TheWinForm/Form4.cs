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
using static TheWinForm.imageUploader;
using System.Diagnostics;

namespace TheWinForm
{
    public partial class Form4 : Form
    {
        public string typeCar;

        Order order = new Order();
        User User { get; set; }
        public Form4(User user)
        {
            InitializeComponent();
            User = user;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void myLocationButton_Click(object sender, EventArgs e)
        {
            startDestination.Text = "Floyd Black 2";
        }

        private void endDestination_Validating(object sender, CancelEventArgs e)
        {
            /*if (endDestination.Text == string.Empty)
            {
                MessageBox.Show("Please fill both adresses", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }*/
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            typeCar = CarSelection();
            if (endDestination.Text == string.Empty || startDestination.Text == string.Empty)
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                order.setOrder(User, startDestination.Text, endDestination.Text, typeCar);
                //Debug.WriteLine(order.driverName);

                this.Hide();
            }

        }

        public string CarSelection()
        {
            return radioButton1.Checked ? radioButton1.Text :
            radioButton2.Checked ? radioButton2.Text :
            radioButton3.Checked ? radioButton3.Text :
            radioButton4.Checked ? radioButton4.Text :
            radioButton5.Checked ? radioButton5.Text :
            string.Empty;

        }

        private void startDestination_Validating(object sender, CancelEventArgs e)
        {
            /*if (startDestination.Text == string.Empty)
            {
                MessageBox.Show("Please fill both adresses", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }*/
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
