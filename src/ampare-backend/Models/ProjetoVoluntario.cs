using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ampare_backend.Models
{
    [Table("ProjetoVoluntario")]
    public class ProjetoVoluntario
    {
        [Key]
        public int ProjetoVoluntarioId { get; set; }

        [ForeignKey("Projeto")]
        public int IdProjeto { get; set; }

        [ForeignKey("Voluntario")]
        public int IdVoluntario { get; set; }

        public Projeto Projeto { get; set; }

        public CadastroVoluntario Voluntario { get; set; }

        public bool Status { get; set; }



    }
}