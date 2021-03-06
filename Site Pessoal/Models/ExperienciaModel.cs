﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Site_Pessoal.Models
{
    public class Experiencia
    {
        public int ExperienciaId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Data de Início")]
        public string Data_Inicio { get; set; }

        [StringLength(10)]
        [Display(Name = "Data de Fim")]
        public string Data_Fim { get; set; }
    }
}
