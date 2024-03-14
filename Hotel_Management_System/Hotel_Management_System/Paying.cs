using Hotel_Management_System.Models;
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
using static System.Net.Mime.MediaTypeNames;

namespace Hotel_Management_System
{
    public partial class Paying : Form
    {
        SqlConnection conn = new SqlConnection(@"Server = . ; Database = Hotel_Management_System ;Trusted_connection = true ; Encrypt = false");
        SqlCommand cmd;
        SqlDataReader reader;
        public Paying()
        {
            InitializeComponent();
        }

        private void paym_Click(object sender, EventArgs e)
        {
            int number = int.Parse(pay.Text);
            string selectPriceinDayRoom = $"SELECT [Pay_Down] FROM [Hotel_Management_System].[dbo].[reservations] WHERE [Room_Number] = {number};";

            double price = 0;
            using (SqlCommand cmd = new SqlCommand(selectPriceinDayRoom, conn))
            {
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    price = reader.GetDouble(0);
                }
                conn.Close();
            }

            double pd = price - Convert.ToDouble(Money.Text);
            double pdown = Convert.ToDouble(Money.Text) - price;
            string free_room = $"UPDATE reservations SET   Pay_Down = '{pd}' " +
                        $"WHERE  Room_Number = '{number}'";
            using (SqlCommand cmds = new SqlCommand(free_room, conn))
            {
                conn.Open();
                int rowsAffected = cmds.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show($"correct mention and pay dowen {pdown}");
                }
                conn.Close();
            }


        }

        private void pay_TextChanged(object sender, EventArgs e)
        {

        }

        private void Money_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Manage_Reservation m = new Manage_Reservation();
            m.Show();
            this.Close();
        }

        private void Paying_Load(object sender, EventArgs e)
        {

        }
    }
}
