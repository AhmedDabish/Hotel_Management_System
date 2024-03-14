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
    public partial class ManageRooms : Form
    {
        SqlConnection conn = new SqlConnection(@"Server = . ; Database = Hotel_Management_System ;Trusted_connection = true ; Encrypt = false");
        SqlCommand cmd;
        SqlDataReader reader;
        public ManageRooms()
        {
            InitializeComponent();

        }

        private void ManageRoomsFormcs_Load(object sender, EventArgs e)
        {
            LoadUserData();


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteroom d=new deleteroom();  
            this.Close();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string room_phone = Room_Phone.Text;
            string describtion = Describtion.Text;
            string prince_in_day = Price_In_Day.Text;
            string room_type = Room_Type.Text;



            if (room_phone.Length == 0 || describtion.Length == 0 || prince_in_day.Length == 0 || room_type.Length == 0)
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                try
                {

                    string insertQuery = $"INSERT INTO rooms (Room_Type,Room_Phone,Room_Description,Price_In_Day) " +
                    $"VALUES ('{room_type}', '{room_phone}', '{describtion}', '{prince_in_day}')";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Room added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add Room.");
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

                    
                }

            }
            LoadUserData();
        }

        private void Room_Num_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Room_Phone.Clear();

            Describtion.Clear();
            Price_In_Day.Clear();
            LoadUserData();
        }

        private void Price_In_Day_TextChanged(object sender, EventArgs e)
        {

        }






        private void LoadUserData()
        {
            try
            {
                string selectQuery = "SELECT Room_Number, Room_Type, Room_Phone, Free,Price_In_Day, Room_Description FROM rooms";

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
            home.Show();
            this.Close();
        }
    }
}
