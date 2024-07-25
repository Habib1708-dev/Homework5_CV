using System.ComponentModel.DataAnnotations;

namespace Homework5_CV.Models
{
    public class CVViewModel
    {
    
        [Required(ErrorMessage = "First Name is required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Birthday is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Nationality is required")]
        [Display(Name = "Nationality")]
        public string Nationality { get; set; }

        [Required(ErrorMessage = "Sex is required")]
        [Display(Name = "Sex")]
        public string Sex { get; set; }

        
        [Display(Name = "Skills")]
        public Dictionary<string, bool> Skills { get; set; } = new Dictionary<string, bool>();

        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Confirm is required")]
        [Display(Name = "Email Confirmation")]
        [Compare("Email", ErrorMessage = "The email and confirmation email do not match")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public  string EmailConfirm { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters long")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[^\da-zA-Z]).*$",
        ErrorMessage = "Password must contain at least one letter, one digit, and one special character")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Value 1 is required")] 
        [Display(Name = "Value 1")]
        public int Val1 { get; set; }

        [Required(ErrorMessage = "Value 2 is required")]
        [Display(Name = "Value 2")]
        public int Val2 { get; set; }

        [Required(ErrorMessage = "Value 3 is required")]
        [Display(Name = "Value 3")]
        public int Val3 { get; set; }

        [Display(Name = "Photo")]
        [Required(ErrorMessage = "The image is required")]
        [DataType(DataType.Upload)]
        public IFormFile Photo { get; set; }

        // Additional properties or formatting methods can be added as needed
    }

}

