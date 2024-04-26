using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static TheWinForm.authentication;

namespace TheWinForm
{
    public partial class Form3 : Form
    {
        SqlConnection sqlCon;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;

            // Validate input before attempting authentication
            if (!string.IsNullOrWhiteSpace(user) && !string.IsNullOrWhiteSpace(pass))
            {
                User authenticatedUser = DatabaseManager.AuthenticateUser(user, pass);

                if (authenticatedUser != null)
                {
                    // Display the username on Form5
                    Form4 welcome = new Form4(authenticatedUser);
                    welcome.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            List<System.Drawing.Color> colours = new List<System.Drawing.Color>
            {
                System.Drawing.Color.Black,
                System.Drawing.Color.Firebrick,
                System.Drawing.Color.Lime,
                System.Drawing.Color.Lavender,
                System.Drawing.Color.Magenta,
                System.Drawing.Color.Orange,
                System.Drawing.Color.PaleGreen,
                System.Drawing.Color.PowderBlue,
                System.Drawing.Color.RosyBrown,
                System.Drawing.Color.Chartreuse,
                System.Drawing.Color.AliceBlue,
                System.Drawing.Color.DarkKhaki,
                System.Drawing.Color.Azure,
                System.Drawing.Color.Peru,
                System.Drawing.Color.Honeydew,
                System.Drawing.Color.DimGray,
                System.Drawing.Color.Ivory

            };


            int pick = rnd.Next(0, colours.Count);

            this.BackColor = colours[pick];
            button1.ForeColor = colours[pick];
            button2.ForeColor = colours[pick];

        }
    }
}

