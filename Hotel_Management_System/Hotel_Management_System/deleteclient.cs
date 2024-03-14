using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class deleteclient : Form
    {
        SqlConnection conn = new SqlConnection(@"Server = . ; Database = Hotel_Management_System ;Trusted_connection = true ; Encrypt = false");
        SqlCommand cmd;
        SqlDataReader reader;
        public deleteclient()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String National_ID = textBox1.Text;
            try
            {
                string deleteQuery = $"DELETE FROM clients WHERE National_ID = '{National_ID}'";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No user found with the specified National ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
                textBox1.Clear();
            }


        }

        private void deleteclient_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Manage_Clients m= new Manage_Clients();
            m.Show();   
            this.Close();
        }
    }
}
