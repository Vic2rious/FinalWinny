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

namespace TheWinForm
{
    public partial class Form2 : Form
    {
        private User authenticatedUser;

        public Form2(User user)
        {
            InitializeComponent();
            authenticatedUser = user; // Assign the authenticated user to the local variable

            // Additional initialization or actions based on the authenticated user can be added here
            // For example, you can set labels or perform other operations.
            usernameLabel.Text = $"Thank you for using our services\n" +
                $"{authenticatedUser.Username}! \n";

            if (user.Image != null && user.Image.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(user.Image))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                    uploadBtn.Text = "Change Image";
                }
            }
        }





        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int r = 255, g = 0, b = 0;

        List<System.Drawing.Color> colours = new List<System.Drawing.Color>
            {

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int pick = rnd.Next(0, colours.Count);

            this.BackColor = Color.FromArgb(r, g, b);
            uploadBtn.ForeColor = Color.FromArgb(r, g, b);
            usernameLabel.ForeColor = colours[pick];
            uploadBtn.BackColor = colours[pick];




            if (r > 0 && b == 0)
            {
                r -= 5;
                g += 5;
            }
            if (g > 0 && r == 0)
            {
                g -= 5;
                b += 5;
            }
            if (b > 0 && g == 0)
            {
                b -= 5;
                r += 5;
            }
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();  // Creating an OpenFileDialog instance

            // Setting the filter for the file dialog to allow only specific image file types
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";

            // Checking if the user selected a file and clicked the OK button
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedImagePath = openFileDialog.FileName;  // Getting the path of the selected image
                    Image selectedImage = Image.FromFile(selectedImagePath);  // Creating an Image object from the selected file

                    byte[] imageData = ImageToByteArray(selectedImage);  // Converting the image to a byte array

                    // Updating the user's image in the database
                    UploadImage(authenticatedUser.Username, imageData);

                    // Displaying the uploaded image on the form
                    pictureBox1.Image = selectedImage;

                    // Hiding the upload button since the user now has an image
                    uploadBtn.Hide();
                }
                catch (Exception ex)
                {
                    // Displaying an error message if an exception occurs during image upload
                    MessageBox.Show($"Error uploading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
