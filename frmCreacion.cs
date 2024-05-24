using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prySistemaCatala
{
    public partial class frmCreacion : Form
    {
        public frmCreacion()
        {
            InitializeComponent();
        }

        private void frmCreacion_Load(object sender, EventArgs e)
        {

        }
        clsUsuario clsUsuario = new clsUsuario();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string perfil = txtPefil.Text;

            clsUsuario.CrearUsuario(usuario, contraseña, perfil);
            
        }
    }
}
