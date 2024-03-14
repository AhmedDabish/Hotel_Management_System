using Microsoft.Data.SqlClient;

namespace Hotel_Management_System
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection(@"Server = . ; Database = Hotel_Management_System ;Trusted_connection = true ; Encrypt = false");
        SqlCommand cmd;
        SqlDataReader reader;
        public Login()
        {
            InitializeComponent();
        }




        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username=textBox1.Text;
            string password=textBox2.Text;
            try
            { string select_qr;
                select_qr = $"select Name , Password from admins\r\n where Name = '{username}' and Password ='{password}';";

                cmd = new SqlCommand(select_qr, conn);
                conn.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show($"Login successful {username}");
                    

                    Home h = new Home();
                    h.Show();

                }
                else
                {
                   MessageBox.Show("Invalid username or password. Please try again.");
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            textBox1.Clear();
            textBox2.Clear();



        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
