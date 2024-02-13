using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'billingDatabaseDataSet.Purchase' table. You can move, or remove it, as needed.
            this.purchaseTableAdapter.Fill(this.billingDatabaseDataSet.Purchase);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            try
            {
                iExit = MessageBox.Show("confirm exit", "Billing Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                ;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            decimal bread = numericUpDown1.Value;
            decimal beans = numericUpDown2.Value;
            decimal rice = numericUpDown3.Value;
             decimal breadcost = 10;
             decimal beanscost = 10;
             decimal ricecost = 10;
            decimal totalcost = (bread * breadcost) + (beans* beanscost) + (rice * ricecost);

            MessageBox.Show("Thanks for shooping : Total Amount: " + totalcost);

            string cs = "data source=EPINHYDW0BE7\\SQLEXPRESS;initial catalog=BillingDatabase;integrated security=true";
            SqlConnection conn = null;
            using (conn = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                conn.Open();
                cmd.CommandText = "INSERT INTO Purchase (CustomerId,OrderDate,TotalPurchase) VALUES(@CustomerId, @OrderDate, @TotalPurchase)";
                cmd.Parameters.AddWithValue("@CustomerId", 1);
                cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@TotalPurchase", totalcost);
               int row =cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    Console.WriteLine("Data insertion success");
                    MessageBox.Show("Data Inserted Success");
                }
                else
                {
                    Console.WriteLine("data insertion failed");
                    MessageBox.Show("Data Inserted Failed");
                }
                conn.Close();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
