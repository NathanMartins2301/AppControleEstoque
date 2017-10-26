using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Controle;
namespace Visao
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();
                usuario.Login = txtLogin.Text;
                usuario.Senha = txtSenha.Text;
                
                Ctrl_User controle = new Ctrl_User();

                if (controle.validarUsuario(usuario))
                {
                    this.Tag = usuario;
                    this.DialogResult = DialogResult.Yes;
                    this.Close();


                }



            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

       
    }
}
