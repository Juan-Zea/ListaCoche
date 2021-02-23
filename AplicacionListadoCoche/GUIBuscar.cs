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
    public partial class GUIBuscar : Form
    {
        public GUIBuscar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {   

            int ID;
            ID = Convert.ToInt32(txtID.Text.Trim());
            Coche buscado=null;
            try
            {
                buscado= ServicioCoche.buscarId(ID);
                txtModelo.Text = buscado.getModelo();
                txtNumeroAir.Text = Convert.ToString(buscado.getNumeroAirBag());
                txtMarca.Text = buscado.getMarca();
                dateTPFecha.Value = buscado.getFechaCreacion();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
    }
}
