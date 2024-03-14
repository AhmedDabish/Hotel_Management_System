using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public string Full_Name { get; set; }
       
        public string Phone { get; set; }
        public string National_Id { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Address { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
