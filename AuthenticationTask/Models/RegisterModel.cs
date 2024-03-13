using System.ComponentModel.DataAnnotations;

namespace AuthenticationTask.Models
{
    public class RegisterModel
    {
        [Required, StringLength(100)]
        public string FirstName { get; set; }

        [Required, StringLength(100)]
        public string FatherName { get; set; }

        [Required, StringLength(100)]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { set; get; }

        [Required]
        public string Address { get; set; }

        [Required, StringLength(50)]
        public string Username { get; set; }

        [Required, StringLength(128)]
        public string Email { get; set; }

        [Required, StringLength(256)]
        public string Password { get; set; }
    }
}
