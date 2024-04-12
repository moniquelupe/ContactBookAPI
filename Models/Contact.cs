using System.ComponentModel.DataAnnotations;

namespace ContactBookAPI.Models
{
    public class Contact
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [Phone]
        public string Phone { get; set; }
    }
}
