using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ampare_backend.Models
{

    [Table("Cadatro_Voluntarios")]
    public class  CadastroVoluntario
    {
        [Key]
        public int Id { get; set; }
        public string Nome {get; set; }
        public int Idade {get; set; }

        public List<Projeto> Projetos { get; } = new();
    }
}
