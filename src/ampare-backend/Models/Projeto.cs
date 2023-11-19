using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ampare_backend.Models
{
    [Table("Projetos")]
    public class Projeto
    {

        [Key]
        public int IdProjeto { get; set; }
        
        public CadastroOng CadastroOng { get; set; } 
        [ForeignKey("Id")]
        public int IdOng { get; set; }
        
        public string ResponsavelProjeto { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string NomeProjeto { get; set; }

        public string DescricaoProjeto { get; set; }   

        public Boolean StatusProjeto { get; set; } 
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string CidadeProjeto { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string EstadoProjeto { get; set; }

        public List<CadastroVoluntario> Voluntarios { get; } = new();

    }

}
