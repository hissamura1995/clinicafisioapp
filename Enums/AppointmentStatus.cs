using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace clinicafisioapp.Enums
{
    public enum AppointmentStatus
    {
        [Display(Name = "Agendado")]
        Scheduled = 1,

        [Display(Name = "Concluído")]
        Completed = 2,

        [Display(Name = "Cancelado")]
        Cancelled = 3,

        [Display(Name = "Faltou")]
        NoShow = 4
    }
}
