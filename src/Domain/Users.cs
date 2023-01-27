using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Mail field is required")]
        [MaxLength(150, ErrorMessage = "The email field only accepts a maximum of 150 characters")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Password field is required")]
        [MaxLength(300, ErrorMessage = "The Password field only accepts a maximum of 300 characters")]
        public string Password { get; set; }
    }
}
