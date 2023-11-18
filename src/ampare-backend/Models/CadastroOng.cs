using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ampare_backend.Models
{
    [Table("CadastroOngs")]
    public class CadastroOng
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório informar o nome da Ong ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Email ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Endereço ")]
        public string Endereço { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Telefone ")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a Senha ")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
