using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site_Pessoal.Models
{
    public class CartaConducao
    {
        public int CartaConducaoId { get; set; }

        [Required]
        [StringLength(100)]
        public string Tipo { get; set; }
    }
}
