using System.ComponentModel.DataAnnotations;

namespace ampare_backend.Models
{
    public class Cadastro
    {
        [Key]
        public int IdCadastro { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar login!")]
        public string Login {get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar senha!")]
        [DataType(DataType.Password)]
        public string Senha {get; set; }

        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Obrigatório informar email!")]
        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Endereco { get; set; }
        
        public Boolean Status { get; set; }

    }
}
