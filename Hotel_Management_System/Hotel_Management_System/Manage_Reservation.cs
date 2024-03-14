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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;
using System.Diagnostics;

namespace Hotel_Management_System.Models
{
    public partial class Manage_Reservation : Form
    {
        SqlConnection conn = new SqlConnection(@"Server = . ; Database = Hotel_Management_System ;Trusted_connection = true ; Encrypt = false");
        SqlCommand cmd;
        SqlDataReader reader;
        public Manage_Reservation()
        {

            InitializeComponent();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Room_num_TextChanged(object sender, EventArgs e)
        {
        }
        private void Pay_up_TextChanged(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string clientId = Client_id.Text;
            string roomNum = Room_num.Text;
            string payUp = Pay_up.Text;
            string checkRoomQuery = $"SELECT Free FROM rooms WHERE Room_Number = {roomNum}";
            string freeStatus = "";

            using (SqlCommand checkCmd = new SqlCommand(checkRoomQuery, conn))
            {
                conn.Open();
                SqlDataReader reader = checkCmd.ExecuteReader();

                if (reader.HasRows && reader.Read())
                {
                    freeStatus = reader["Free"].ToString();
                }

                conn.Close();
            }


            if (clientId == null || roomNum == null || payUp == null || freeStatus == "No")
            {
                MessageBox.Show("Please fill all fields or Room busy");
            }

            else
            {
                try
                {
                    string selectPriceinDayRoom = $"SELECT [Price_In_Day] FROM [Hotel_Management_System].[dbo].[rooms] WHERE [Room_Number] = {roomNum};";

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
                    DateTime startDate = Date_in.Value;
                    DateTime endDate = Date_out.Value;
                    TimeSpan difference = endDate - startDate;
                    int numberOfDays = difference.Days;
                    double totalprice = (double)numberOfDays * price;
                    double.TryParse(payUp, out double payup);
                    double paydown = totalprice - (double)payup;
                    string free_room = $"UPDATE rooms SET Free = 'No' WHERE Room_Number = {roomNum}";
                    using (SqlCommand cmds = new SqlCommand(free_room, conn))
                    {
                        conn.Open();
                        int rowsAffected = cmds.ExecuteNonQuery();
                        conn.Close();

                    }

                    string insertQuery = $"INSERT INTO reservations (Client_Id, Room_Number, DateIn, Date_Out, Pay_Up,Pay_Down,Total_Price) " +
                    $"VALUES ('{clientId}', '{roomNum}', '{Date_in.Value}', '{Date_out.Value}', '{payUp}', '{paydown}', '{totalprice}')";

                    using (SqlCommand cmds = new SqlCommand(insertQuery, conn))
                    {
                        conn.Open();
                        int rowsAffected = cmds.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add user.");
                        }
                        conn.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {

                    Client_id.Clear();
                    Room_num.Clear();
                    Pay_up.Clear();

                }
            }
            LoadUserData();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Client_id.Clear();
            Room_num.Clear();
            Pay_up.Clear();

        }

        private void Manage_Reservation_Load(object sender, EventArgs e)
        {
            LoadUserData();

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            EndRservation h = new EndRservation();
            h.Show();
            this.Close();
        }


        private void Edit_Click(object sender, EventArgs e)
        {
            string clientId = Client_id.Text;
            string roomNum = Room_num.Text;
            string dateIn = Date_in.Text;
            string dateOut = Date_out.Text;
            string payUp = Pay_up.Text;

            if (string.IsNullOrEmpty(clientId) || string.IsNullOrEmpty(roomNum) || string.IsNullOrEmpty(payUp))
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                try
                {
                    string selectPriceinDayRoom = $"SELECT [Price_In_Day] FROM [Hotel_Management_System].[dbo].[rooms] WHERE [Room_Number] = {roomNum};";

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

                    DateTime startDate = Date_in.Value;
                    DateTime endDate = Date_out.Value;
                    TimeSpan difference = endDate - startDate;
                    int numberOfDays = difference.Days;

                    double totalprice = numberOfDays * price;
                    double.TryParse(payUp, out double payup);
                    double paydown = totalprice - payup;

                    string free_room = $"UPDATE rooms SET Free = 'No' WHERE Room_Number = {roomNum}";
                    using (SqlCommand cmds = new SqlCommand(free_room, conn))
                    {
                        conn.Open();
                        int rowsAffected = cmds.ExecuteNonQuery();
                        conn.Close();
                    }

                    string updateReservation = $"UPDATE reservations SET DateIn = '{Date_in.Value}',Date_Out = '{Date_out.Value}', Pay_Up = '{payUp}', Pay_Down = '{paydown}', Total_Price = '{totalprice}' " +
                        $"WHERE Client_Id = '{clientId}' AND Room_Number = '{roomNum}'";

                    using (SqlCommand cmds = new SqlCommand(updateReservation, conn))
                    {
                        conn.Open();
                        int rowsAffected = cmds.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Reservation updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update reservation.");
                        }
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Client_id.Clear();
                    Room_num.Clear();
                    Pay_up.Clear();
                }
            }
            LoadUserData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Paying h = new Paying();
            this.Close();   
            h.Show();
        }






        private void LoadUserData()
        {
            try
            {
                string selectQuery = "SELECT Client_Id, Room_Number, DateIn, Date_Out, Pay_Up, Pay_Down,Total_Price FROM reservations";

                using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                {
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Close();
            home.Show();
        }
    }
}
