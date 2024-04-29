using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TheWinForm
{
    // Authentication class
    public class authentication
    {
        /* By having a dedicated User class, it becomes easier to extend and modify user-related properties 
        * or methods in the future without directly affecting the authentication logic. 
        * This modularity enhances code maintainability. */
        public class User
        {
            public string Username { get; set; } // User's username property
            public string email { get; set; } // User's email property
            public string gender { get; set; } // User's gender property
            public DateTime? date { get; set; } // User's date property
            public byte[] Image { get; set; } // User's image property (binary data)

            
        }

        public class Order
        {
            public User User { get; set; }
            public string Username { get; set; } // User's username property
            public int carId { get; set; } // User's email property
            public string startDestination { get; set; } // User's gender property
            public string endDestination{ get; set; } // User's date property
            public string carType{ get; set; } // User's image property (binary data)
            public int arrivalTime { get; set; } // User's image property (binary data)
            public string driverName { get; set; } // User's image property (binary data)
            public string licensePlate { get; set; } // User's image property (binary data)
            public int rideId { get; set; } // User's image property (binary data)

            private SqlCommand cmd;
            private SqlConnection cn;
            private SqlDataReader dr;

            public Order setOrder(User theUser, string start, string end, string car)
            {
                this.User = theUser;
                this.Username = theUser.Username;
                this.startDestination = start;
                this.endDestination = end;
                this.carType = car;

                using (cn = new SqlConnection(@"Data Source=LAB109PC16\SQLEXPRESS; Initial Catalog=TAXIDDV; Integrated Security=True;"))
                {
                    cn.Open();

                    // Checking if the username already exists
                    using (cmd = new SqlCommand($"SELECT TOP 1 * FROM cars2 WHERE car_type = '{carType}' ORDER BY NEWID()", cn))
                    {
                        try
                        {
                            using (var reader = cmd.ExecuteReader())
                            {
                                if (reader.Read()) // if there is at least one row
                                {
                                    // Retrieve each column value and store in variables
                                    this.carId = (int)reader["car_id"];
                                    this.driverName = (string)reader["driver_name"];
                                    this.licensePlate = (string)reader["license_plate"];
                                    this.arrivalTime = (int)reader["time"];

                                    //Debug.WriteLine(this.arrivalTime);

                                    // god help us all
                                    //UPDATE cars2
                                    //SET time = ROUND(100 + (ABS(CAST(CAST(NEWID() AS VARBINARY) AS INT)) % 901), 0);
                                }
                                else
                                {
                                    Debug.WriteLine("No cars found.");
                                }
                            }

                            

                        }
                        catch (Exception ex)
                        {
                            // Handle potential exceptions such as connection issues
                            Debug.WriteLine("An error with cars2 occurred: " + ex.Message);
                        }

                        

                        try
                        {
                            using (cmd = new SqlCommand("INSERT INTO rides1 \r\n" +
                                "(username, car_id, start_destination, end_destination, budget, arrival_time, driver_name, license_plate)\r\n" +
                                "VALUES\r\n(@username, @carId, @start, @end, @carType, @time, @driverName, @plate);\r\n", cn))
                            {
                                cmd.Parameters.AddWithValue("@username", this.Username);
                                cmd.Parameters.AddWithValue("@carId", this.carId);
                                cmd.Parameters.AddWithValue("@start", this.startDestination);
                                cmd.Parameters.AddWithValue("@end", this.endDestination);
                                cmd.Parameters.AddWithValue("@carType", this.carType);
                                cmd.Parameters.AddWithValue("@time", this.arrivalTime);
                                cmd.Parameters.AddWithValue("@driverName", this.driverName);
                                cmd.Parameters.AddWithValue("@plate", this.licensePlate);
                                cmd.ExecuteNonQuery();

                                
                            }
                        }

                        catch (Exception ex)
                        {
                            // Handle potential exceptions such as connection issues
                            Debug.WriteLine("An error with rides1 occurred: " + ex.Message);
                        }

                        try
                        {
                            using (cmd = new SqlCommand($"SELECT TOP 1 * FROM rides1 WHERE car_id = '{this.carId}' AND start_destination = '{this.startDestination}' AND end_destination = '{this.endDestination}'", cn))
                            {
                                using (var reader = cmd.ExecuteReader())
                                {
                                    if (reader.Read()) // if there is at least one row
                                    {
                                        // Retrieve each column value and store in variables
                                        this.rideId = (int)reader["ride_id"];


                                        //Debug.WriteLine("asdf" + this.rideId);

                                        // god help us all
                                        //UPDATE cars2
                                        //SET time = ROUND(100 + (ABS(CAST(CAST(NEWID() AS VARBINARY) AS INT)) % 901), 0);

                                        MessageBox.Show("Your Order has been created.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        new Form6(this).Show();
                                    }
                                    else
                                    {
                                        Debug.WriteLine("No ride_id found.");
                                    }
                                }
                            }
                        }

                        catch (Exception ex)
                        {
                            // Handle potential exceptions such as connection issues
                            Debug.WriteLine("An error with rides1 occurred: " + ex.Message);
                        }


                    }


                }

                return this;
            }

            public void setRating(string rating)
            {
                try
                {
                    using (cn = new SqlConnection(@"Data Source=LAB109PC16\SQLEXPRESS; Initial Catalog=TAXIDDV; Integrated Security=True;"))
                    {
                        cn.Open();

                        using (cmd = new SqlCommand("UPDATE rides1\r\n" +
                            "SET rating = @rating\r\n" +
                            "WHERE ride_id = @rideId;", cn))
                        {
                            cmd.Parameters.AddWithValue("@rideId", this.rideId);
                            cmd.Parameters.AddWithValue("@rating", rating);

                            Debug.WriteLine(rating);
                            Debug.WriteLine(this.rideId);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Your Rating has been submitted.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle potential exceptions such as connection issues
                    Debug.WriteLine("An error with rating occurred: " + ex.Message);
                }
            }

        }

        /* The DatabaseManager class is responsible for handling database operations, including user authentication. 
        * This is a good practice in software design, as it allows for better organization and maintainability. */
        public class DatabaseManager
        {
            // Method to authenticate user
            public static User AuthenticateUser(string username, string password)
            {
                User user = RetrieveUserInformation(username, password);
                return user;
            }

            /*The RetrieveUserInformation method encapsulates the logic for querying the database and retrieving user information based on the provided username and password. 
            * This method is private, meaning it is intended to be used only within the DatabaseManager class. */
            private static User RetrieveUserInformation(string username, string password)
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC16\SQLEXPRESS; Initial Catalog=TAXIDDV; Integrated Security=True;"))
                {
                    sqlCon.Open(); // Open SQL connection
                    string email = "";
                    string gender = "";
                    DateTime? date = new DateTime();

                    string loginQuery = "SELECT COUNT(1) FROM Table_1 WHERE Username=@Username AND Password=@Password";
                    string imgQuery = "SELECT img FROM Table_1 WHERE Username=@Username AND Password=@Password";
                    string infoQuery = "Select * from Table_1 WHERE username = @username";
                    using (SqlCommand loginCmd = new SqlCommand(loginQuery, sqlCon))
                    {
                        using (SqlCommand imgCmd = new SqlCommand(imgQuery, sqlCon))
                        {
                            using (SqlCommand infoCmd = new SqlCommand(infoQuery, sqlCon))
                            {
                                loginCmd.CommandType = CommandType.Text;
                                imgCmd.CommandType = CommandType.Text;
                                infoCmd.CommandType = CommandType.Text;

                                loginCmd.Parameters.AddWithValue("@Username", username);
                                loginCmd.Parameters.AddWithValue("@Password", password);
                                imgCmd.Parameters.AddWithValue("@Username", username);
                                imgCmd.Parameters.AddWithValue("@Password", password);
                                infoCmd.Parameters.AddWithValue("@username", username);

                                int count = Convert.ToInt32(loginCmd.ExecuteScalar());

                                if (count == 1)
                                {
                                    using (SqlDataReader reader = infoCmd.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            email = (string)reader["email"];
                                            gender = (string)reader["gender"];
                                            date = (DateTime)reader["date"];

                                           
                                        }
                                    }

                                    using (SqlDataReader reader = imgCmd.ExecuteReader())
                                    {
                                        if (reader.Read())
                                        {
                                            byte[] imageData = reader["img"] as byte[];
                                            return new User { Username = username, Image = imageData, email = email, gender = gender, date = date};
                                        }
                                    }
                                }

                                return null; // Return null if no user is found with the specified username and password
                            }
                            
                        }
                    }
                }
            }
        }

    }
}