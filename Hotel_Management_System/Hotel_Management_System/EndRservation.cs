using Hotel_Management_System.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel_Management_System
{
    public partial class EndRservation : Form
    {
        SqlConnection conn = new SqlConnection(@"Server = . ; Database = Hotel_Management_System ;Trusted_connection = true ; Encrypt = false");
        SqlCommand cmd;
        SqlDataReader reader;
        public EndRservation()
        {
            InitializeComponent();
        }

        private void End_Click(object sender, EventArgs e)
        {
            string n = Roomnum.Text;
            if (string.IsNullOrEmpty(n))
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand($"DELETE FROM reservations WHERE Room_Number = '{n}'", conn))
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Reservation deleted successfully!");
                        }
                    }

                    using (SqlCommand cmds = new SqlCommand($"UPDATE rooms SET Free = 'yes' WHERE Room_Number = '{n}'", conn))
                    {
                        int rowsAffected = cmds.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        private void Roomnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Manage_Reservation manage = new Manage_Reservation();
            this.Close();
            manage.Show();
        }

        private void EndRservation_Load(object sender, EventArgs e)
        {

        }
    }
}
