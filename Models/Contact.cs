using System.ComponentModel.DataAnnotations;

namespace ContactBookAPI.Models
{
    public class Contact
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; } = ""; // define o valor inicial para 'Name'
        
        [Required]
        [EmailAddress]
        public string Email { get; set; } = ""; // define o valor inicial para 'Email'
        
        [Required]
        [Phone]
        public string Phone { get; set; } = ""; // define o valor inicial para 'Phone'
    }
}
