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
    public partial class frmMenuEdades : Form
    {
        public string nombre_juego;
        frmMenu menu = Application.OpenForms.OfType<frmMenu>().SingleOrDefault();
        Clases.Memoria memoria = new Clases.Memoria();
        Clases.Atencion atencion = new Clases.Atencion();

        public frmMenuEdades()
        {
            InitializeComponent();           
        }

        private void frmMenuEdades_Load(object sender, EventArgs e)
        {
            escribirTexto();
        }

        private void escribirTexto()
        {
            btnJuego1.Text = Res.Jugar;
            btnJuego2.Text = Res.Jugar;
            btnJuego3.Text = Res.Jugar;
            btnPuntosJuego1.Text = Res.Puntuaciones;
            btnPuntosJuego2.Text = Res.Puntuaciones;
            btnPuntosJuego3.Text = Res.Puntuaciones;
            switch (menu.juego)
            {
                case "atencion":
                    lblJuego1.Text = Res.Elegir_la_letra_correcta;
                    lblJuego2.Text = Res.Donde_esta_pikachu;
                    lblJuego3.Text = Res.Colores_y_Significados;
                    pbxJuego1.Image = Image.FromFile("..\\..\\Resources\\juego_a1.jpg");
                    pbxJuego2.Image = Image.FromFile("..\\..\\Resources\\juego_a2.jpg");
                    pbxJuego3.Image = Image.FromFile("..\\..\\Resources\\juego_a3.jpg");
                    break;
                case "memoria":
                    lblJuego1.Text = Res.Tablas_de_multiplicar;
                    lblJuego2.Text = Res.Provincias_del_Ecuador;
                    lblJuego3.Text = Res.Habia_una_vez;
                    pbxJuego1.Image = Image.FromFile("..\\..\\Resources\\juego_m1.jpg");
                    pbxJuego2.Image = Image.FromFile("..\\..\\Resources\\juego_m2.jpg");
                    pbxJuego3.Image = Image.FromFile("..\\..\\Resources\\juego_m3.jpg");
                    break;
            }
        }

        private void btnJuego1_Click(object sender, EventArgs e)
        {
            menu.AbrirFormulario<frmInicio>();
            frmInicio inicio = Application.OpenForms.OfType<frmInicio>().SingleOrDefault();
            switch (menu.juego)
            {
                case "atencion":
                    nombre_juego = "Elegir la letra correcta";
                    atencion.nombre_juego = nombre_juego;
                    menu.lblEncabezado.Text = Res.Elegir_la_letra_correcta;
                    inicio.lblObjetivo.Text = atencion.mostrarObjetivo();
                    inicio.lblInstrucciones.Text = atencion.mostrarInstrucciones();
                    break;
                case "memoria":
                    nombre_juego = "Tablas de multiplicar";
                    memoria.nombre_juego = nombre_juego;
                    menu.lblEncabezado.Text = Res.Tablas_de_multiplicar;
                    inicio.lblObjetivo.Text = memoria.mostrarObjetivo();
                    inicio.lblInstrucciones.Text = memoria.mostrarInstrucciones();
                    break;
            }
        }

        private void btnJuego2_Click(object sender, EventArgs e)
        {
            menu.AbrirFormulario<frmInicio>();
            frmInicio inicio = Application.OpenForms.OfType<frmInicio>().SingleOrDefault();
            switch (menu.juego)
            {
                case "atencion":
                    nombre_juego = "Dónde está pikachu";
                    atencion.nombre_juego = nombre_juego;
                    menu.lblEncabezado.Text = Res.Donde_esta_pikachu;
                    inicio.lblObjetivo.Text = atencion.mostrarObjetivo();
                    inicio.lblInstrucciones.Text = atencion.mostrarInstrucciones();
                    break;
                case "memoria":
                    nombre_juego = "Provincias del Ecuador";
                    memoria.nombre_juego = nombre_juego;
                    menu.lblEncabezado.Text = Res.Provincias_del_Ecuador;
                    inicio.lblObjetivo.Text = memoria.mostrarObjetivo();
                    inicio.lblInstrucciones.Text = memoria.mostrarInstrucciones();
                    break;
            }
        }

        private void btnJuego3_Click(object sender, EventArgs e)
        {
            menu.AbrirFormulario<frmInicio>();
            frmInicio inicio = Application.OpenForms.OfType<frmInicio>().SingleOrDefault();
            switch (menu.juego)
            {
                case "atencion":
                    nombre_juego = "Colores y Significados";
                    atencion.nombre_juego = nombre_juego;
                    menu.lblEncabezado.Text = Res.Colores_y_Significados;
                    inicio.lblObjetivo.Text = atencion.mostrarObjetivo();
                    inicio.lblInstrucciones.Text = atencion.mostrarInstrucciones();
                    break;
                case "memoria":
                    nombre_juego = "Había una vez";
                    memoria.nombre_juego = nombre_juego;
                    menu.lblEncabezado.Text = Res.Habia_una_vez;
                    inicio.lblObjetivo.Text = memoria.mostrarObjetivo();
                    inicio.lblInstrucciones.Text = memoria.mostrarInstrucciones();
                    break;
            }
        }

        private void btnPuntosJuego1_Click(object sender, EventArgs e)
        {
            frmPuntuaciones frmPuntuaciones = new frmPuntuaciones(menu.juego == "atencion" ? 1 : 4, menu.juego == "atencion" ? Res.Elegir_la_letra_correcta : Res.Tablas_de_multiplicar);
            frmPuntuaciones.Show();
        }

        private void btnPuntosJuego2_Click(object sender, EventArgs e)
        {
            frmPuntuaciones frmPuntuaciones = new frmPuntuaciones(menu.juego == "atencion" ? 2 : 5, menu.juego == "atencion" ? Res.Donde_esta_pikachu : Res.Provincias_del_Ecuador);
            frmPuntuaciones.Show();
        }

        private void btnPuntosJuego3_Click(object sender, EventArgs e)
        {
            frmPuntuaciones frmPuntuaciones = new frmPuntuaciones(menu.juego == "atencion" ? 3 : 6, menu.juego == "atencion" ? Res.Colores_y_Significados : Res.Habia_una_vez);
            frmPuntuaciones.Show();
        }
    }
}
