using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace clinicafisioapp.Models
{
    public class Address
    {
        [DisplayName("CEP")]
        [Required(ErrorMessage = "CEP é um campo obrigatório")]
        public string ZipCode { get; set; }

        [DisplayName("Endereço")]
        [Required(ErrorMessage = "Endereço é um campo obrigatório")]
        public string Street { get; set; }

        [DisplayName("Complemento")]
        public string? Complement { get; set; }

        [DisplayName("Cidade")]
        [Required(ErrorMessage = "Cidade é uma seleção obrigatória")]
        public string City { get; set; }

        [DisplayName("Estado")]
        [Required(ErrorMessage = "Estado é uma seleção obrigatório")]
        public string State { get; set; }
    }
}
