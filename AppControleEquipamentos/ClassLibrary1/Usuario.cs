using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Usuario
    {
        private int perfil;
        private String login;
        private String senha;

        public String Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public String Login
        {
            get { return login; }
            set { login = value; }
        }

        public int Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }
    }
}
