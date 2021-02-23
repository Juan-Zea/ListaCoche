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
    public partial class GUIActualizar : Form
    {
        public GUIActualizar()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            String modelo;
            int numeroAirBag;
            String marca;
            Coche nuevoCoche;
            int ID;
            ID = Convert.ToInt32(txtID.Text.Trim());
            modelo = txtModelo.Text.Trim();
            numeroAirBag = Convert.ToInt32(txtNumeroAir.Text);
            marca = txtMarca.Text.Trim();

            ServicioCoche.actualizarCoche(ID,modelo,numeroAirBag,marca);

            txtModelo.Text = "";
            txtNumeroAir.Text = "";
            txtMarca.Text = "";
            txtID.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int ID;
            ID = Convert.ToInt32(txtID.Text.Trim());
            Coche buscado = null;
            try
            {
                buscado = ServicioCoche.buscarId(ID);
                txtModelo.Text = buscado.getModelo();
                txtNumeroAir.Text = Convert.ToString(buscado.getNumeroAirBag());
                txtMarca.Text = buscado.getMarca();
                dateTPFecha.Value = buscado.getFechaCreacion();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
