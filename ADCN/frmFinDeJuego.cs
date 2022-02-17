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
    public partial class frmFinDeJuego : Form
    {
        private string mensaje;
        private int idGame;
        private string nombreJuego;

        public frmFinDeJuego(string mensaje, int idGame, string nombreJuego)
        {
            this.nombreJuego = nombreJuego;
            this.mensaje = mensaje;
            this.idGame = idGame;
            InitializeComponent();
        }

        private void frmFinDeJuego_Load(object sender, EventArgs e)
        {
            escribirTexto();
            pbxTrophy.Enabled = true;
            delay.Start();
        }

        private void delay_Tick(object sender, EventArgs e)
        {
            delay.Stop();
            pbxTrophy.Enabled = false;
            lblMensaje.Visible = true;
            lblEncabezado.Visible = true;
            btnVolverAJugar.Visible = true;
            btnPuntuaciones.Visible = true;
            btnVerVideo.Visible = true;
            btnSalir.Visible = true;
        }

        private void escribirTexto()
        {
            lblEncabezado.Text = Res.Fin_del_juego;
            btnPuntuaciones.Text = Res.Puntuaciones;
            btnVolverAJugar.Text = Res.Aceptar;
            lblMensaje.Text = mensaje;
            btnVolverAJugar.Text = Res.Volver_a_jugar;
            btnVerVideo.Text = Res.Ver_video;
            btnSalir.Text = Res.Salir;
        }

        private void btnVolverAJugar_Click(object sender, EventArgs e)
        {
            switch (idGame)
            {
                case 1:
                    frmJuegoAtencion1 juegoAtencion1 = Application.OpenForms.OfType<frmJuegoAtencion1>().SingleOrDefault();
                    juegoAtencion1.volverAJugar();
                    break;
                case 2:
                    frmJuegoAtencion2 juegoAtencion2 = Application.OpenForms.OfType<frmJuegoAtencion2>().SingleOrDefault();
                    juegoAtencion2.volverAJugar();
                    break;
                case 3:
                    frmJuegoAtencion3 juegoAtencion3 = Application.OpenForms.OfType<frmJuegoAtencion3>().SingleOrDefault();
                    juegoAtencion3.volverAJugar();
                    break;
                case 4:
                    frmJuegoMemoria1 juegoMemoria1 = Application.OpenForms.OfType<frmJuegoMemoria1>().SingleOrDefault();
                    juegoMemoria1.volverAJugar();
                    break;
                case 5:
                    frmJuegoMemoria2 juegoMemoria2 = Application.OpenForms.OfType<frmJuegoMemoria2>().SingleOrDefault();
                    juegoMemoria2.volverAJugar();
                    break;
                case 6:
                    frmJuegoMemoria3 juegoMemoria3 = Application.OpenForms.OfType<frmJuegoMemoria3>().SingleOrDefault();
                    juegoMemoria3.volverAJugar();
                    break;
            }
            this.Close();
        }

        private void btnVerVideo_Click(object sender, EventArgs e)
        {
            switch (idGame)
            {
                case 1:
                    frmJuegoAtencion1 juegoAtencion1 = Application.OpenForms.OfType<frmJuegoAtencion1>().SingleOrDefault();
                    juegoAtencion1.abrirVideo();
                    break;
                case 2:
                    frmJuegoAtencion2 juegoAtencion2 = Application.OpenForms.OfType<frmJuegoAtencion2>().SingleOrDefault();
                    juegoAtencion2.abrirVideo();
                    break;
                case 3:
                    frmJuegoAtencion3 juegoAtencion3 = Application.OpenForms.OfType<frmJuegoAtencion3>().SingleOrDefault();
                    juegoAtencion3.abrirVideo();
                    break;
                case 4:
                    frmJuegoMemoria1 juegoMemoria1 = Application.OpenForms.OfType<frmJuegoMemoria1>().SingleOrDefault();
                    juegoMemoria1.abrirVideo();
                    break;
                case 5:
                    frmJuegoMemoria2 juegoMemoria2 = Application.OpenForms.OfType<frmJuegoMemoria2>().SingleOrDefault();
                    juegoMemoria2.abrirVideo();
                    break;
                case 6:
                    frmJuegoMemoria3 juegoMemoria3 = Application.OpenForms.OfType<frmJuegoMemoria3>().SingleOrDefault();
                    juegoMemoria3.abrirVideo();
                    break;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMenu menu = Application.OpenForms.OfType<frmMenu>().SingleOrDefault();
            menu.lblEncabezado.Text = Res.Bienvenida + " " + menu.nombre_est.First().ToString().ToUpper() + menu.nombre_est.Substring(1);
            switch (idGame)
            {
                case 1:
                    frmJuegoAtencion1 juegoAtencion1 = Application.OpenForms.OfType<frmJuegoAtencion1>().SingleOrDefault();
                    juegoAtencion1.abrirMenuPrincipal();
                    break;
                case 2:
                    frmJuegoAtencion2 juegoAtencion2 = Application.OpenForms.OfType<frmJuegoAtencion2>().SingleOrDefault();
                    juegoAtencion2.abrirMenuPrincipal();
                    break;
                case 3:
                    frmJuegoAtencion3 juegoAtencion3 = Application.OpenForms.OfType<frmJuegoAtencion3>().SingleOrDefault();
                    juegoAtencion3.abrirMenuPrincipal();
                    break;
                case 4:
                    frmJuegoMemoria1 juegoMemoria1 = Application.OpenForms.OfType<frmJuegoMemoria1>().SingleOrDefault();
                    juegoMemoria1.abrirMenuPrincipal();
                    break;
                case 5:
                    frmJuegoMemoria2 juegoMemoria2 = Application.OpenForms.OfType<frmJuegoMemoria2>().SingleOrDefault();
                    juegoMemoria2.abrirMenuPrincipal();
                    break;
                case 6:
                    frmJuegoMemoria3 juegoMemoria3 = Application.OpenForms.OfType<frmJuegoMemoria3>().SingleOrDefault();
                    juegoMemoria3.abrirMenuPrincipal();
                    break;
            }
            this.Close();
        }

        private void btnPuntuaciones_Click(object sender, EventArgs e)
        {
            frmPuntuaciones frmPuntuaciones = new frmPuntuaciones(idGame, nombreJuego);
            frmPuntuaciones.Show();
        }
    }
}
