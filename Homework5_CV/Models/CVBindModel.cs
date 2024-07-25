using System.ComponentModel.DataAnnotations;

namespace Homework5_CV.Models
{
    public class CVBindModel
    {
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Birthday is required")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Nationality is required")]
        public string Nationality { get; set; }

        [Required(ErrorMessage = "Sex is required")]
        public string Sex { get; set; }

        
        public List<string> Skills { get; set; } = new List<string>();

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Email Confirmation is required")]
        [Compare("Email", ErrorMessage = "The email and confirmation email do not match")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string EmailConfirm { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters long")]
        [RegularExpression(@"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[^\da-zA-Z]).*$",
        ErrorMessage = "Password must contain at least one letter, one digit, and one special character")]
        public string Password { get; set; }

        [Required]
        public int Val1 { get; set; }

        [Required]
        public int Val2 { get; set; }

        [Required]
        public int Val3 { get; set; }

        [Required(ErrorMessage = "The image is required")]
        [DataType(DataType.Upload)]
        public IFormFile Photo { get; set; }

    }
}
