using System.ComponentModel.DataAnnotations;

namespace CQRSandMediatRinOnionArchitecture.Application.DTOs.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}