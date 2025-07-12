using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;
using Microsoft.EntityFrameworkCore;

namespace clinicafisioapp.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("CPF")]
        [Required(ErrorMessage = "CPF é um campo obrigatório")]
        [StringLength(14)]
        public string CPF { get; set; }

        [DisplayName("Nome Completo")]
        [Required(ErrorMessage = "Nome é um campo obrigatório")]
        public string Name { get; set; }

        [DisplayName("Data de nascimento")]
        [Required(ErrorMessage = "Data de nascimento é um campo obrigatório")]
        public DateTime? BirthDate { get; set; }

        [NotMapped]
        public int? Age => BirthDate.HasValue ? DateTime.Now.Year - BirthDate.Value.Year : null;

        [DisplayName("Gênero")]
        [Required(ErrorMessage = "Gênero é uma seleção obrigatória")]
        public string Gender { get; set; }

        [DisplayName("DDD")]
        [Required(ErrorMessage = "DDD é um campo obrigatório")]
        public string DDD { get; set; }

        [DisplayName("Telefone")]
        [Required(ErrorMessage = "Telefone é um campo obrigatório")]
        public string Phone { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email é um campo obrigatório")]
        public string Email { get; set; }

        [Required]
        public Address Address { get; set; }
    }
}
