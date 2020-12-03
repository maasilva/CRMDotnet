
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRMDotnet.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Display(Name = "Nome")]
        [StringLength(80, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Sobrenome")]
        [StringLength(80, MinimumLength = 3)]
        [Required]
        public string Surname { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime Birthday { get; set; }

        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set; }

        [RegularExpression(@"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$")]
        [Display(Name = "Telefone")]
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string Phone { get; set; }

    }
}