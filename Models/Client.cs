using System.ComponentModel.DataAnnotations;
namespace Lab3.Models
{
    public class Client : User
    {
        [Required(ErrorMessage = "Please enter your name")]
        [StringLength(50, ErrorMessage = "Name is too long. Max 30 characters.")]
        public string ClientName { get; set; }

        public Client(int userId, string userName, string email, string password, string role, string phoneNumber, string address, string clientName) : base(userId, userName, email, password, role, phoneNumber, address)
        {
            ClientName = clientName;
        }
        public Client()
        {
            ClientName = "";

        }
    }
}
