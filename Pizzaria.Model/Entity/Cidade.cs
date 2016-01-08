using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzaria.Model.Entity
{
    [Table(nameof(Cidade))]
    public class Cidade
    {
        [Key]
        public int CidadeID { get; set; }
        [MaxLength(50, ErrorMessage = "Nome da Cidade deve conter no máximo 50 caracteres")]      
        public string Nome { get; set; }
    }
}