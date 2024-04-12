using System.ComponentModel.DataAnnotations;

namespace MVCCRUD.Models
{
    public class User
    {
        [Key]
        [Required(ErrorMessage = "User ID is required")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter your userName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter your role")]
        public string Role { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter your address")]
        public string Address { get; set; }


        public User()
        {
            UserId = 0;
            UserName = "";
            Email = "";
            Password = "";
            Role = "";
            PhoneNumber = "";
            Address = "";

        }

        public User(int userId, string userName, string email, string password, string role, string phoneNumber, string address)
        {
            UserId = userId;
            UserName = userName;
            Email = email;
            Password = password;
            Role = role;
            PhoneNumber = phoneNumber;
            Address = address;
        }
    }
}