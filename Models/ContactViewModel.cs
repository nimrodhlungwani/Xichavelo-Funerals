using System.ComponentModel.DataAnnotations;

namespace Xichavelo.Web.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Please enter your full name.")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your contact number.")]
        [Phone(ErrorMessage = "Invalid phone format.")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a specific subject topic.")]
        public string Subject { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please write your message details.")]
        [MinLength(10, ErrorMessage = "Message should be at least 10 characters long.")]
        public string Message { get; set; } = string.Empty;
    }
}