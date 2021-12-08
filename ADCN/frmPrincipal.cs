using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADCN
{
    public partial class frmPrincipal : Form
    {
        private Clases.DesarrolloCognitivo app = Clases.DesarrolloCognitivo.Instance();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (app.cargarLogo())
            {
                pbxLogo.Visible = true;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("ERROR! Nombre vacío","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                app.registrarNombre(txtNombre.Text);
                app.mostrarMenu();
                this.Close();
            }      
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (app.cerrarAplicacion())
            {
                Application.Exit();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
