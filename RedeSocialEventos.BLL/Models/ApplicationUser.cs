using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocialEventos.BLL.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

    }
}
