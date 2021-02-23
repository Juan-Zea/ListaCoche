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
    public partial class GUIPrincipal : Form
    {
        public GUIPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void mostrarCochesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIMostrarCoches gui = new GUIMostrarCoches();
            gui.Show();
        }

        private void agregarCocheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIAdicionarCoches gui = new GUIAdicionarCoches();
            gui.Show();
        }

        private void actualizarCocheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIActualizar gui = new GUIActualizar();
            gui.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Juan David Zea Gonzalez --- 2220161030 / no aplica XD");
        }

        private void buscarReferenciaCocheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIBuscar gui = new GUIBuscar();
            gui.Show();
        }
    }
}
