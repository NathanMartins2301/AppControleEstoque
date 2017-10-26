using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;

namespace Controle
{
    
        public class Ctrl_Usuario
        {

            public bool validarUsuario(Usuario _user)
            {


                try
                {
                    if (_user.Login.Equals("nathanmcunha") && _user.Senha.Equals("1234"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }


            }

        }
    }

