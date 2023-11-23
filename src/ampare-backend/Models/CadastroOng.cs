using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ampare_backend.Models
{
    [Table("CadastroOngs")]
    public class CadastroOng : Cadastro
    {
        
      public List<Projeto> Projetos { get; } = new();
    }
}
