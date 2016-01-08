using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzaria.Model.Entity
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int ClienteID { get; set; }
        [MaxLength(length: 50, ErrorMessage = "Nome do cliente deve conter no máximo 50 caracteres {0} {1}")]
        [MinLength(2, ErrorMessage = "Nome do Cliente deve conter mais que 2 caracteres")]
        [Required(ErrorMessage ="Nome do Cliente é obrigatório")]
        public string Nome { get; set; }
       
       
        public virtual Endereco Endereco { get; set; }
        public virtual Contato Contato{ get; set; }
}

}
