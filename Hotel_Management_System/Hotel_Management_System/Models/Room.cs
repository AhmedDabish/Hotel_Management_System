using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Models
{
    public class Room
    {
        [Key]
        public int Room_Number { get; set; }
        public string Room_Type { get; set; }
        public string Room_Phone { get; set; }
        public string Room_Description { get; set; }
        public string Free { get; set; }
        public double Price_In_Day { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
