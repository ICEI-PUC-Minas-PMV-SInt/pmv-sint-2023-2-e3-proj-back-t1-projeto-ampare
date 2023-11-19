using System.ComponentModel.DataAnnotations;

namespace ampare_backend.Models
{
    public class Cadastro
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Obrigatório informa login !")]

        public string Login {get; set; }
        [Required(ErrorMessage = "Obrigatório informa senha !")]
        [DataType(DataType.Password)]

        public int Senha {get; set; }

        public String Nome { get; set; }
        [Required(ErrorMessage = "Obrigatório informa email !")]

        public String Email {  get; set; }
        public String Telefone { get; set; }
        public String Endereço { get; set; }
        public Boolean Status { get; set; }

    }
}
