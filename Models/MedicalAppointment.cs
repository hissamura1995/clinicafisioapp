using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace clinicafisioapp.Models
{
    public class MedicalAppointment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PatientId { get; set; }
        public Patient Patient { get; set; }

        [Required]
        [DisplayName("Data e hora")]
        public DateTime StartDateTime { get; set; }

        [DisplayName("Duração (minutos)")]
        public int DurationInMinutes { get; set; } = 60; // Default 1 hour //

        [Required]
        [DisplayName("Tipo de atendimento")]
        public string? Type { get; set; }

        [DisplayName("Observações")]
        public string? Notes { get; set; }

    

    }
}
