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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            // Validaciones de integridad de datos

            // Validaciones de negocio front

            String nombre = txtImporte.Text;

            PlazoFijoNegocio plazoFijoNegocio = new PlazoFijoNegocio();
            plazoFijoNegocio.obtenerTasa(12, 1000);



        }

        // Evento _Load del formulario. Se dispara antes de visualizar el formulario.
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Carga inicial de datos en el  formulario");
        }

        // Evento _Click del boton. Se dispara al realizar un click sobre un boton
        private void btonContratar_Click(object sender, EventArgs e)
        {
            this.Hide();

            MenuPrincipal form = new MenuPrincipal();
            form.ShowDialog();

        }
    }
}
