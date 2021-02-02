using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site_Pessoal.Models
{
    public class Linguas
    {
        public int LinguasId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

    }
}
