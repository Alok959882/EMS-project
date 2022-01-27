using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace EMS.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Image { get; set; }
        [Required(ErrorMessage = "Required")]
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "Required")]
    }

    
}
  