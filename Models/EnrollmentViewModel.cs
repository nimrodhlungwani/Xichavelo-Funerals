using System.ComponentModel.DataAnnotations;

namespace Xichavelo.Web.Models
{
    public class EnrollmentViewModel
    {
        [Required(ErrorMessage = "Selected insurance plan is required.")]
        [Display(Name = "Selected Plan")]
        public string SelectedPlan { get; set; } = string.Empty;

        [Required(ErrorMessage = "Applicant full name is required.")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "National ID number or Passport number is required.")]
        [Display(Name = "National ID / Passport Number")]
        public string NationalId { get; set; } = string.Empty;

        [Required(ErrorMessage = "Contact number is required.")]
        [Phone]
        [Display(Name = "Contact Number")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Valid email address is required.")]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Physical home address is required.")]
        [Display(Name = "Physical Address")]
        public string PhysicalAddress { get; set; } = string.Empty;

        [Range(1, 15, ErrorMessage = "Dependents must match policy specifications.")]
        [Display(Name = "Total Dependents")]
        public int TotalDependents { get; set; }

        [Required(ErrorMessage = "You must accept the terms and policy waiting periods.")]
        public bool AcceptTerms { get; set; }
    }
}