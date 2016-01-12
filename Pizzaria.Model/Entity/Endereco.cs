using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzaria.Model.Entity
{
    [Table(nameof(Endereco))]
    public class Endereco
    {
        [Key]
        [ForeignKey(nameof(Cliente))]
        public int ClienteID { get; set; }
        [Display(Name = "Ponto de Referência")]
        [Description(description: "Ponto de Referência")]
        [DisplayName("Ponto de Referência")]
        public string Referencia { get; set; }
        [ForeignKey(name: nameof(Bairro))]       
        public int BairroID { get; set; }
        [ForeignKey(name: nameof(Cidade))]
        public int CidadeID { get; set; }
        [MaxLength(10, ErrorMessage = "Número deve conter no máximo 10 caracteres")]
        public string Numero { get; set; }
        [ForeignKey(name:nameof(Logradouro))]     
        public int LogradouroID { get; set; }
        public virtual Bairro Bairro { get; set; }
        public virtual Cidade Cidade { get; set; }
        public virtual Logradouro Logradouro { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}