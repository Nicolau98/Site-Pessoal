using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site_Pessoal.Models
{
    public class LoginViewModel
    {
        public string Utilisador { get; set; }

        public string Password { get; set; }

        public bool Lembrar { get; set; }
    }
}
