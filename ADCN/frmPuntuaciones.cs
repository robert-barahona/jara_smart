using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADCN.Models;

namespace ADCN
{
    public partial class frmPuntuaciones : Form
    {
        private int idGame;
        private List<Result> resultList;
        private string nombreJuego;

        public frmPuntuaciones(int idJuego, string nombreJuego)
        {
            this.nombreJuego = nombreJuego;
            idGame = idJuego;
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inicilizarTextos()
        {
            btnAceptar.Text = Res.Aceptar;
            lblJuego.Text = Res.Puntuaciones + "\n" + nombreJuego;
            dgvResults.Columns[1].HeaderText = Res.Nombre;
            dgvResults.Columns[2].HeaderText = Res.Puntuacion;
        }

        private void pintarFormulario()
        {
            frmMenu menu = Application.OpenForms.OfType<frmMenu>().SingleOrDefault();
            this.BackColor = menu.pnlMenu.BackColor;
            dgvResults.ColumnHeadersDefaultCellStyle.BackColor = menu.lblEncabezado.BackColor;
            dgvResults.DefaultCellStyle.BackColor = menu.lblEncabezado.BackColor;
            dgvResults.BackgroundColor = menu.lblEncabezado.BackColor;
            btnAceptar.BackColor = menu.pnlTop.BackColor;
        }

        private async void frmPuntuaciones_Load(object sender, EventArgs e)
        {
            inicilizarTextos();
            pintarFormulario();

            var i = 0;
            dgvResults.Rows.Clear();
            resultList = await Data.SQLiteHelper.Instance().GetResultsByGame(idGame);
            OrdenarPorMetodoBurbuja();

            foreach (var result in resultList)
            {
                i++;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvResults);
                row.Cells[0].Value = i;
                row.Cells[1].Value = result.name;
                row.Cells[2].Value = result.points.ToString();
                dgvResults.Rows.Add(row);
            }
        }

        public void OrdenarPorMetodoBurbuja()
        {
            Result result;
            for (int a = 1; a < resultList.Count; a++)
            {
                for (int b = resultList.Count - 1; b >= a; b--)
                {
                    if (resultList[b - 1].points < resultList[b].points)
                    {
                        result = resultList[b - 1];
                        resultList[b - 1] = resultList[b];
                        resultList[b] = result;
                    }
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
