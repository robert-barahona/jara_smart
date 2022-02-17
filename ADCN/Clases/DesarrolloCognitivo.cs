using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADCN.Clases
{
    class DesarrolloCognitivo
    {
        public string nombre_est;
        private static DesarrolloCognitivo instance;

        public static DesarrolloCognitivo Instance()
        {
            if(instance == null)
            {
                instance = new DesarrolloCognitivo();
            }
            return instance;
        }


        private DesarrolloCognitivo()
        {

        }

        public void abrirVentanaPrincipal()
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
        }

        public void mostrarMenu()
        {
            frmMenu menu = new frmMenu();
            menu.Show();
        }

        public void mostrarLogin()
        {
            frmPrincipal login = new frmPrincipal();
            login.Show();
        }

        public bool cerrarAplicacion()
        {
            return true;
        }

        public bool cargarLogo()
        {
            return true;
        }

        public void registrarNombre(string nombre_est)
        {
            this.nombre_est = nombre_est;
        }
    }
}
