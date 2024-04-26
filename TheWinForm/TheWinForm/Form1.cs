using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static TheWinForm.authentication;

namespace TheWinForm
{
    public partial class Form1 : Form
    {

        private SqlCommand cmd;
        private SqlConnection cn;
        private SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            uNameTxt.Clear();
            txtpassword.Clear();
            emailTxt.Clear();
            uNameTxt.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(uNameTxt.Text) ||
                string.IsNullOrEmpty(emailTxt.Text) ||
                string.IsNullOrEmpty(comboBox1.Text) ||
                string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Please fill all gaps!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                using (cn = new SqlConnection(@"Data Source=LAB109PC16\SQLEXPRESS; Initial Catalog=TAXIDDV; Integrated Security=True;"))
                {
                    cn.Open();

                    // Checking if the username already exists
                    using (cmd = new SqlCommand("SELECT COUNT(1) FROM Table_1 Where username = @Username", cn))
                    {
                        cmd.Parameters.AddWithValue("@username", uNameTxt.Text);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count == 1)
                        {
                            MessageBox.Show("Username already exists, please try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            // Inserting user information into the database
                            using (cmd = new SqlCommand("INSERT INTO Table_1 (username, password, email, gender, img)\r\nVALUES (@username, @password, @email, @gender, NULLIF(CONVERT(varbinary(max), @img), ''))", cn))
                            {
                                cmd.Parameters.AddWithValue("@username", uNameTxt.Text);
                                cmd.Parameters.AddWithValue("@email", emailTxt.Text);
                                cmd.Parameters.AddWithValue("@password", txtpassword.Text);
                                cmd.Parameters.AddWithValue("@gender", comboBox1.SelectedItem);
                                //cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                                cmd.Parameters.AddWithValue("@img", "");
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Your Account is created.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                User authenticatedUser = DatabaseManager.AuthenticateUser(uNameTxt.Text, txtpassword.Text);
                                new Form2(authenticatedUser).Show();
                                this.Hide();
                            }
                        }

                    }
                }


            }

        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (emailTxt.Text != string.Empty)
            {
                if (!IsValidEmail(emailTxt.Text))
                {
                    MessageBox.Show("email not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    emailTxt.SelectAll();
                    e.Cancel = true;
                }
            }
        }

        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
                return false;

            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }

        private void txtUserName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (uNameTxt.Text.Length <= 5 && uNameTxt.Text.Length != 0)
            {
                MessageBox.Show("Username should be at least 5 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                uNameTxt.Focus();
                e.Cancel = true;
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            length.Show();
            capital.Show();
            lowercase.Show();
            number.Show();

            if (txtpassword.Text.Length > 8)
                length.ForeColor = Color.Green;
            else
                length.ForeColor = Color.Red;

            if (txtpassword.Text.Any(char.IsUpper))
                capital.ForeColor = Color.Green;
            else
                capital.ForeColor = Color.Red;

            if (txtpassword.Text.Any(char.IsLower))
                lowercase.ForeColor = Color.Green;
            else
                lowercase.ForeColor = Color.Red;

            if (txtpassword.Text.Any(char.IsDigit))
                number.ForeColor = Color.Green;
            else
                number.ForeColor = Color.Red;

        }

        private void length_Click(object sender, EventArgs e)
        {

        }

        private void capital_Click(object sender, EventArgs e)
        {

        }

        private void number_Click(object sender, EventArgs e)
        {

        }

        private void lowercase_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!(txtpassword.Text.Length > 8 && txtpassword.Text.Any(char.IsUpper) && txtpassword.Text.Any(char.IsLower) && txtpassword.Text.Any(char.IsDigit)))
            {
                MessageBox.Show("One or more password criteria(s) hasn't been met", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.SelectAll();
                e.Cancel = true;
            }
        }

        private void uNameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
            button3.ForeColor = colours[pick];



        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}