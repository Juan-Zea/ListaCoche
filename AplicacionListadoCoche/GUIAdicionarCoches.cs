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
    public partial class GUIAdicionarCoches : Form
    {
        public GUIAdicionarCoches()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            String modelo;
            int numeroAirBag;
            String marca;
            Coche nuevoCoche;
            DateTime fechaCreacion;

            modelo = txtModelo.Text.Trim();
            numeroAirBag = Convert.ToInt32(txtNumeroAir.Text);
            marca = txtMarca.Text.Trim();
            fechaCreacion = dateTPFecha.Value.Date;


            nuevoCoche = new Coche(ServicioCoche.condeContar(),modelo,fechaCreacion, numeroAirBag, marca);

            ServicioCoche.adicionarInicio(nuevoCoche);
         

            MessageBox.Show("Nuevo carro");
            txtModelo.Text = "";
            txtNumeroAir.Text = "";
            txtMarca.Text = "";

            txtMarca.Focus();

        }
        
        private void btnAgragarFinal_Click(object sender, EventArgs e)
        {
            String modelo;
            int numeroAirBag;
            String marca;
            Coche nuevoCoche;
            DateTime fechaCreacion;

            modelo = txtModelo.Text.Trim();
            numeroAirBag = Convert.ToInt32(txtNumeroAir.Text);
            marca = txtMarca.Text.Trim();
            fechaCreacion = dateTPFecha.Value.Date;

            nuevoCoche = new Coche(ServicioCoche.condeContar(),modelo,fechaCreacion, numeroAirBag, marca);
            try
            {
               ServicioCoche.adicionarFinal(nuevoCoche);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Nuevo carro");
            txtModelo.Text = "";
            txtNumeroAir.Text = "";
            txtMarca.Text = "";

            txtMarca.Focus();
        }

        private void btnAgrePosi_Click(object sender, EventArgs e)
        {
            String modelo;
            int numeroAirBag;
            String marca;
            Coche nuevoCoche;
            int posicion;
            DateTime fechaCreacion;

            if (txtPosicion.Text == "")
            {
                MessageBox.Show("No se especifico la posición, por favor digitar posición" );
                return;
            }
            modelo = txtModelo.Text.Trim();
            numeroAirBag = Convert.ToInt32(txtNumeroAir.Text);
            marca = txtMarca.Text.Trim();
            fechaCreacion = dateTPFecha.Value.Date;

            posicion = Convert.ToInt32(txtPosicion.Text);

             nuevoCoche = new Coche(ServicioCoche.condeContar(),modelo,fechaCreacion,numeroAirBag, marca);
            try
            {
               ServicioCoche.adicionarPosicion(nuevoCoche, posicion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            MessageBox.Show("Nuevo carro");
            txtModelo.Text = "";
            txtNumeroAir.Text = "";
            txtMarca.Text = "";
            txtPosicion.Text = "";

            txtMarca.Focus();
        }

        private void btnListaAgre_Click(object sender, EventArgs e)
        {
            ServicioCoche.metodoPruebaInsertarNodos();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        
     }

}
