using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ampare_backend.Models
{
    public class CadastroOng
    {
        [Key]
        public int Id {get; set; }
        public string Nome {get; set; }
        public string Email {get; set; }
        public string Endereço {get; set; }
        public string Telefone {get; set; }
    }
}
