using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Models
{
    public class Reservation
    {
        [Key]
        public int Reser_Id { get; set; }
        [ForeignKey("Client")]
        public int Client_Id { get; set;}
        [ForeignKey("Room")]
        public int Room_Number { get; set; }
        public DateTime DateIn { get; set; }

        public DateTime Date_Out { get; set; }
        public double Pay_Up {  get; set; }
        public double Pay_Down { get; set; }
        public double Total_Price { get; set; }
        public Client Client { get; set; }
        public Room Room { get; set; }
    }
}
