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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Management_System
{
    public partial class deleteroom : Form
    {
        SqlConnection conn = new SqlConnection(@"Server = . ; Database = Hotel_Management_System ;Trusted_connection = true ; Encrypt = false");
        SqlCommand cmd;
        SqlDataReader reader;
        public deleteroom()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                string deleteQuery = $"DELETE FROM rooms WHERE Room_Number = '{num.Text}'";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Room deleted successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No Room found with the specified National ID.");
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
                num.Clear();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageRooms n = new ManageRooms();
            this.Close();
            n.Show();
        }

        private void deleteroom_Load(object sender, EventArgs e)
        {

        }
    }
}
