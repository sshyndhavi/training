using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net;
using Microsoft.AspNet.FriendlyUrls;
using System.Data;

namespace StudentInfo.Crud
{
    public partial class crud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void Unnamed2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            try
            {


                string cs = "Data Source=EPINHYDW0BE7\\SQLEXPRESS;Initial Catalog=WordVoyager;Integrated Security=True;";

                SqlConnection conn = null;
                using (conn = new SqlConnection(cs))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO Student (StudentName, Address, Age, Contact) VALUES(@StudentName, @Address, @Age, @Contact)";
                    cmd.Parameters.AddWithValue("@StudentName", name.Text);
                    cmd.Parameters.AddWithValue("@Address", name2.Text);
                    cmd.Parameters.AddWithValue("@Age", name3.Text);
                    cmd.Parameters.AddWithValue("@Contact", name4.Text);

                    cmd.Connection = conn;
                    int _row = cmd.ExecuteNonQuery();

                    if (_row > 0)
                    {
                        Response.Write("<script>alert('Success');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Failed');</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            try
            {


                string cs = "Data Source=EPINHYDW0BE7\\SQLEXPRESS;Initial Catalog=WordVoyager;Integrated Security=True;";

                SqlConnection conn = null;
                using (conn = new SqlConnection(cs))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "UPDATE Student SET StudentName= @StudentName WHERE(Age = @Age)";
                    cmd.Parameters.AddWithValue("@StudentName", name.Text);

                    cmd.Parameters.AddWithValue("@Age", name3.Text);


                    cmd.Connection = conn;
                    int _row = cmd.ExecuteNonQuery();

                    if (_row > 0)
                    {
                        Response.Write("<script>alert('Success');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Failed');</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            try
            {


                string cs = "Data Source=EPINHYDW0BE7\\SQLEXPRESS;Initial Catalog=WordVoyager;Integrated Security=True;";

                SqlConnection conn = null;
                using (conn = new SqlConnection(cs))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "DELETE FROM Student WHERE (StudentName =@StudentName)";
                    cmd.Parameters.AddWithValue("@StudentName", name.Text);




                    cmd.Connection = conn;
                    int _row = cmd.ExecuteNonQuery();

                    if (_row > 0)
                    {
                        Response.Write("<script>alert('Success');</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Failed');</script>");
                    }
                }
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        } 
        protected void Unnamed4_Click(object sender, EventArgs e)
        {
            try
            {


                string cs = "Data Source=EPINHYDW0BE7\\SQLEXPRESS;Initial Catalog=WordVoyager;Integrated Security=True;";

                SqlConnection conn = null;
                using (conn = new SqlConnection(cs))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection= conn;
                    cmd.CommandText = "SELECT * FROM Student";
                    
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "Student");
                    DataTable dt = ds.Tables["Student"];

                    foreach (DataRow dr in dt.Rows)
                    {
                        Response.Write("<script>alert('Success');</script>");

                    }












                    
                        

                    
                    
                    
                }
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }

    }
    
    
}
