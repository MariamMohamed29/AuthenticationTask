using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AuthenticationTask.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string FathertName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { set; get; }

        [Required]
        public string Address { get; set; }

    }

}
