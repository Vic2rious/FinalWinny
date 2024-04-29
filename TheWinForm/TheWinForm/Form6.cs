using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static TheWinForm.authentication;

namespace TheWinForm
{
    public partial class Form6 : Form
    {

        Order theOrder;
        public Form6(Order order)
        {
            InitializeComponent();

            theOrder = order;
            DriverName.Text = order.driverName;
            licensePlate.Text = order.licensePlate;
            time.Text = theOrder.arrivalTime.ToString();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = (theOrder.arrivalTime / 60).ToString() + ":";
            seconds.Text = (theOrder.arrivalTime % 60).ToString();
            theOrder.arrivalTime -= 45;

            if (theOrder.arrivalTime < 0)
            {
                new Form5(theOrder).Show();
                this.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            theOrder.setRating("Canceled");
            new Form4(theOrder.User).Show();
            this.Close();
        }

        private void timeLeftLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
