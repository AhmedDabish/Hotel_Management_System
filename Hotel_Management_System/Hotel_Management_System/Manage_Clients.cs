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

namespace Hotel_Management_System
{
    public partial class Manage_Clients : Form
    {
        SqlConnection conn = new SqlConnection(@"Server = . ; Database = Hotel_Management_System ;Trusted_connection = true ; Encrypt = false");
        SqlCommand cmd;
        SqlDataReader reader;
        public Manage_Clients()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 0, 0, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


        private void Manage_Clients_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                string selectQuery = "SELECT Id, Full_Name, Email, Phone, Address, National_ID FROM clients";

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

            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells["Full_Name"].Value.ToString();
            textBox2.Text = row.Cells["Email"].Value.ToString();
            textBox3.Text = row.Cells["Phone"].Value.ToString();
            textBox5.Text = row.Cells["Address"].Value.ToString();
            textBox4.Text = row.Cells["National_ID"].Value.ToString();


        }


        private void button4_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string Email = textBox2.Text;
            string Phone = textBox3.Text;
            string Address = textBox5.Text;
            string National_ID = textBox4.Text;


            if (username.Length == 0 || Email.Length == 0 || Phone.Length == 0 || Address.Length == 0 || National_ID.Length == 0)
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                try
                {

                    string insertQuery = $"INSERT INTO clients (Full_Name, Email, Phone, Address, National_ID) " +
                    $"VALUES ('{username}', '{Email}', '{Phone}', '{Address}', '{National_ID}')";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add user.");
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
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }
            }


            LoadUserData();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string Email = textBox2.Text;
            string Phone = textBox3.Text;
            string Address = textBox5.Text;
            string National_ID = textBox4.Text;

            if (username.Length == 0 || Email.Length == 0 || Phone.Length == 0 || Address.Length == 0 || National_ID.Length == 0)
            {
                MessageBox.Show("Please fill all fields");
                return; 
            }

            try
            {
                string updateQuery = $"UPDATE clients " +
                    $"SET Full_Name = @username, Email = @Email, Phone = @Phone, Address = @Address " +
                    $"WHERE National_ID = @NationalId";
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username); 
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Phone", Phone);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@NationalId", National_ID);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User data updated successfully!");
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
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                LoadUserData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteclient anotherForm = new deleteclient();

            // Show AnotherForm
            anotherForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Home anotherForm = new Home();
            anotherForm.Show();
            this.Close();
        }
    }
}
