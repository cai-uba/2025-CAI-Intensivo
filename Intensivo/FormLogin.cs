using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intensivo
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            LoginNegocio loginNegocio = new LoginNegocio();
            LoginResponse login = loginNegocio.login(txtUsername.Text, txtPassword.Text);

            if (login.PerfilUsuario.Equals("ALUMNO"))
            {
                this.Hide();
                FormMenuAlumno formMenuAlumno = new FormMenuAlumno();
                formMenuAlumno.ShowDialog();
            }

        }
    }
}
