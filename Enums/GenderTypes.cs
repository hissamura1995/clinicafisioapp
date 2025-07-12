using System.ComponentModel.DataAnnotations;

namespace clinicafisioapp.Enums
{
    public enum GenderTypes
    {
        [Display(Name = "Masculino")]
        Male,

        [Display(Name = "Feminino")]
        Female,

        [Display(Name = "Outro")]
        Other,
    }
}
