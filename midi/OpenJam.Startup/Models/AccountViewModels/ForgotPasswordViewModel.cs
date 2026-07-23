using System.ComponentModel.DataAnnotations;

namespace OpenJam.Startup.Models.AccountViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
