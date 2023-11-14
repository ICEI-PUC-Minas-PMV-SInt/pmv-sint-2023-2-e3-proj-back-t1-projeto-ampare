﻿using System.ComponentModel.DataAnnotations;

namespace ampare_backend.Models
{
    public class CadastroVoluntario
    {
        [Key]
        public int Id { get; set; }
        public string Nome {get; set; }
        public int Idade {get; set; }
    }
}
