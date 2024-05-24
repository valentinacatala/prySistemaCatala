using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySistemaCatala
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
        clsUsuario clsUsuario = new clsUsuario(); 
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (clsUsuario.ValidarUsuario(usuario, contraseña))
            {
                clsUsuario.RegistroLogInicioSesion();

                frmReporte frmReporte = new frmReporte();
                frmReporte.Show();
                this.Hide(); 
            }
            else
            {
                
                MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmCreacion frmCreacion = new frmCreacion();
            frmCreacion.Show();
            this.Hide();
        }
    }
}
