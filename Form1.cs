using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGIN
{
    public partial class FrmLOGGIN : Form
    {
        Usuario usuarios = new Usuario();
        public FrmLOGGIN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = tbxusuario.Text;
            string password = tbxcontraseña.Text;

            var lista = usuarios.Obtenerusuario();
            var validar = lista.FirstOrDefault(u => u.NombreUsuario == user && u.Contrasenia == password);

            if (validar != null)
            {
                this.Hide();
                Inicio inicio = new Inicio();
                inicio.Show();
            }
            else
            {

                MessageBox.Show("Fallaste...");
            }
        }
    }
}
