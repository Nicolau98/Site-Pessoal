using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site_Pessoal.Models
{
    public class EducacaoFormacao
    {
        public int EducacaoFormacaoId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        public string Descricao { get; set; }

        [Required]
        [StringLength(10)]
        public string Data_Inicio { get; set; }

        [StringLength(10)]
        public string Data_Fim { get; set; }
    }
}

