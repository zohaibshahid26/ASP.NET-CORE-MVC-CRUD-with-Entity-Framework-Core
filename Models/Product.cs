using System.ComponentModel.DataAnnotations;
namespace Lab3.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Please enter the product id")]
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the product name")]
        public required string Name { get; set; }
        [Required(ErrorMessage = "Please enter the product price")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please enter the product description")]
        public string Description { get; set; }


        public Product()
        {
            Id = 0;
            Name = "";
            Price = 0;
            Description = "";
        }

        public Product(int id, string name, decimal price, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
        }

    }
}
