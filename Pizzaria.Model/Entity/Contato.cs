using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzaria.Model.Entity
{
    [Table(nameof(Contato))]
    public class Contato
    {
        [Key]
        [ForeignKey(nameof(Cliente))]
        public int ClienteID { get; set; }
        [Display(Name = "Telefone Fixo")]
        [Description(description: "Telefone Fixo")]
        [DisplayName("Telefone Fixo")]
        [MaxLength(13, ErrorMessage = "Telefone do Cliente deve conter no máximo 12 caracteres {0} {1}")]
        public string Fixo { get; set; }
        [Display(Name = "Telefone Celular")]
        [Description(description: "Telefone Celular")]
        [DisplayName("Telefone Celular")]
        [MaxLength(13, ErrorMessage = "Telefone do Cliente deve conter no máximo 13 caracteres {0} {1}")]
        public string Celular { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}