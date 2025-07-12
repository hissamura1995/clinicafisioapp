using Microsoft.AspNetCore.Identity;

namespace clinicafisioapp.Models
{
    public class ApplicationUser : IdentityUser
    {
        public int? PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}
