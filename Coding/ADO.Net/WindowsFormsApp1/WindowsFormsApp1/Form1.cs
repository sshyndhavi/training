using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string cs = "data source=EPINHYDW0BE7\\SQLEXPRESS;initial catalog=WordVoyager;integrated security=true";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new SqlConnection
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    // Open the connection
                    connection.Open();

                    // Define your SQL insert query
                    string query = "INSERT INTO Users (Username,PasswordHash,UserId) VALUES (@Username,@PasswordHash,8)";

                    // Create a new SqlCommand object
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the SQL query
                        command.Parameters.AddWithValue("@Username", textBox1.Text);
                        command.Parameters.AddWithValue("@PasswordHash", textBox2.Text);

                        // Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();


                        // Check if rows were affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No rows affected.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new SqlConnection
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    // Open the connection
                    connection.Open();

                    // Define your SQL insert query
                    string query = "UPDATE Users SET PasswordHash = 1 WHERE Username = 'Hyndavi'";
                    // Create a new SqlCommand object
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the SQL query
                        command.Parameters.AddWithValue("@Username", textBox1.Text);
                        command.Parameters.AddWithValue("@PasswordHash", textBox2.Text);

                        // Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();


                        // Check if rows were affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No rows affected.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new SqlConnection
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    // Open the connection
                    connection.Open();

                    // Define your SQL insert query
                    string query = "DELETE Users WHERE Username =@Username";
                    // Create a new SqlCommand object
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the SQL query
                        command.Parameters.AddWithValue("@Username", textBox1.Text);


                        // Execute the SQL command
                        int rowsAffected = command.ExecuteNonQuery();


                        // Check if rows were affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No rows affected.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new SqlConnection
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    // Open the connection
                    connection.Open();

                    // Define your SQL insert query
                    string query = "SELECT * FROM Users";
                    // Create a new SqlCommand object
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the SQL query
                        command.Parameters.AddWithValue("@Username", textBox1.Text);
                        command.Parameters.AddWithValue("@PasswordHash", textBox2.Text);
                        SqlDataAdapter adp = new SqlDataAdapter(command);
                        DataSet ds = new DataSet();
                        adp.Fill(ds, "Users");
                        DataTable dt = ds.Tables["Users"];

                        foreach (DataRow dr in dt.Rows)
                        {
                            MessageBox.Show(dr["Username"] + " " + dr["PasswordHash"]);
                        }



                    }



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new SqlConnection
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    // Open the connection
                    connection.Open();

                    // Define your SQL insert query
                    string query = "SELECT * FROM Users";
                    // Create a new SqlCommand object
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the SQL query
                        command.Parameters.AddWithValue("@Username", textBox1.Text);
                        command.Parameters.AddWithValue("@PasswordHash", textBox2.Text);
                        SqlDataReader reader = command.ExecuteReader();
                        // Execute the SQL command
                        while (reader.Read())
                        {
                            MessageBox.Show(reader["Username"] + " " + reader["PasswordHash"]);
                        }
                        reader.Close();
                        connection.Close();






                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
           
            using (SqlCommand cmd = new SqlCommand("GetUsers", conn))
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        MessageBox.Show(dr["UserId"] + "" + dr["UserName"] + "" + dr["Email"] + dr["PasswordHash"] + dr["RegistrationDate"]);
                    }
                   
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




            }
        }
    }
}
    









