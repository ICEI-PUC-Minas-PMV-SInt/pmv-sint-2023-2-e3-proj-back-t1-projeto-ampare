using System.ComponentModel.DataAnnotations;

namespace ampare_backend.Models
{
    public class Cadastro
    {
        [Key]
        public int Id { get; set; }
        public string Login {get; set; }
        public int Senha {get; set; }
    }
}
