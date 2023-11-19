using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ampare_backend.Models
{
    public class CadastroVoluntario : Cadastro
    {
        public int Idade {get; set; }

        public List<Projeto> Projetos { get; } = new();
    }
}
