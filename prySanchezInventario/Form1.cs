using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySanchezInventario
{
    public partial class Form1 : Form
    {   
        string varCodigo ="";
        string varProducto ="";
        int varPrecio = 0;
        int varStock= 0;
        string varDescripcion = "";
        string varCategoria = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            lblRegistroID.Text = txtCodigo.Text + "/" + txtProducto.Text + "/" + "$" + txtPrecio.Text +"/" + txtStock.Text;
                varCodigo = txtCodigo.Text;
                varProducto = txtProducto.Text;
                varPrecio = Convert.ToInt32(txtPrecio.Text);
                varStock = Convert.ToInt32(txtStock.Text);
                varDescripcion = txtDescripcion.Text;
                varCategoria = lstCategoria.Text;
        }
    }
}
