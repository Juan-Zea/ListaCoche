using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionListadoCoche
{
    public partial class GUIMostrarCoches : Form
    {
        public GUIMostrarCoches()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Coche tem;
            int numFila;

            tem = ServicioCoche.GetCoches();

            if (tem == null)
            {
                MessageBox.Show("No hay Coches!");
                return;
            }

            grilla.Rows.Clear();

            while (tem != null)
            {
                numFila = grilla.Rows.Add();
                grilla.Rows[numFila].Cells[0].Value = tem.getID();
                grilla.Rows[numFila].Cells[1].Value = tem.getMarca();
                grilla.Rows[numFila].Cells[2].Value = tem.getModelo();
                grilla.Rows[numFila].Cells[3].Value = tem.getNumeroAirBag();
                grilla.Rows[numFila].Cells[4].Value = tem.getFechaCreacion().ToString("dd/MM/yyyy");

                tem = tem.getSgte();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            grilla.Rows.Clear();
        }

        private void grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



        }

        private void clickEnBotton(object sender, DataGridViewCellEventArgs e)
        {

            if (grilla.CurrentCell.ColumnIndex == 4)
            {

                MessageBox.Show("Se actualizara 4 ");
            }
            if (grilla.CurrentCell.ColumnIndex == 5)
            {
                MessageBox.Show("Se actualizara 5");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarPri_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioCoche.eliminarPrimero();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnElimnarUlti_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioCoche.eliminarUltimo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnElimPosicion_Click(object sender, EventArgs e)
        {
            try
            {
                int posicion;
                posicion = Convert.ToInt32(txtPosicion.Text);
                ServicioCoche.eliminarPosicion(posicion);
                txtPosicion.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
