using Hotel_Management_System.Models;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage_Clients h = new Manage_Clients();
            h.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageRooms h = new ManageRooms();
            h.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manage_Reservation h = new Manage_Reservation();
            h.Show();
            this.Close();
        }
    }
}
