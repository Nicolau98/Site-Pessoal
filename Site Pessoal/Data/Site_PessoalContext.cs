using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Site_Pessoal.Models;

namespace Site_Pessoal.Data
{
    public class Site_PessoalContext : DbContext
    {
        public Site_PessoalContext (DbContextOptions<Site_PessoalContext> options)
            : base(options)
        {
        }

        public DbSet<Site_Pessoal.Models.Experiencia> Experiencia { get; set; }
    }
}
