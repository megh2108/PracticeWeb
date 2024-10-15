using System.ComponentModel.DataAnnotations;

namespace PracticeWebApi.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string LoginId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }


        [Required]
        public byte[] PasswordHash { get; set; }
        [Required]
        public byte[] PasswordSalt { get; set; }

      

    }
}
