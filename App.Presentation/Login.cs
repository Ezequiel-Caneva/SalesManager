using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Presentation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var form = new Inicio();
            form.Show(); // Mostrar inicio
            this.Hide(); // ocultar logeo 

            form.FormClosing += frm_Closing;  // cuando cerramos llamamos al evento de abajo para mostrar de nuevo el logeo
        }
        private void frm_Closing(object sender, FormClosingEventArgs e)
        {
            txtMail.Text = string.Empty;
            txtClave.Text = string.Empty;
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
