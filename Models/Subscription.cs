using System.ComponentModel.DataAnnotations;
namespace Lab3.Models
{
    public class Subscription
    {
        [Key]
        [Required(ErrorMessage = "Please enter the subscription id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the subscription name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the subscription price")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please enter the subscription description")]
        public string Description { get; set; }

        public Subscription(int id, string name, decimal price, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
        }
        public Subscription()
        {
            Id = 0;
            Name = "";
            Price = 0;
            Description = "";
        }

    }
}
