using System.ComponentModel.DataAnnotations;

namespace Xichavelo.Web.Models
{
    public class EnrollmentViewModel
    {
        [Required(ErrorMessage = "Selected insurance plan is required.")]
        public string SelectedPlan { get; set; } = string.Empty;

        [Required(ErrorMessage = "Applicant full name is required.")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "National ID number or Passport number is required.")]
        public string NationalId { get; set; } = string.Empty;

        [Required(ErrorMessage = "Contact number is required.")]
        [Phone]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Valid email address is required.")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Physical home address is required.")]
        public string PhysicalAddress { get; set; } = string.Empty;

        [Range(1, 15, ErrorMessage = "Dependents must match policy specifications.")]
        public int TotalDependents { get; set; }

        [Required(ErrorMessage = "You must accept the terms and policy waiting periods.")]
        public bool AcceptTerms { get; set; }
    }
}