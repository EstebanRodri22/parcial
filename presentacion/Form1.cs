using BILL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class frmProducto : Form
    {
        
        private GestorVentas gestorVentas = new GestorVentas();

        public frmProducto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            Producto producto = new Producto
            {
                Referencia = txtReferencia.Text,
                Nombre = txtNombre.Text,
                Existencias = int.Parse(txtCantidad.Text),
                PrecioUnitario = double.Parse(txtPrecioUni.Text),
                StockMinimo = int.Parse(txtStock.Text),
                Estado = cmbEstado.SelectedItem.ToString()
            };

           
            gestorVentas.AgregarProducto(producto);

            
            MessageBox.Show("Datos guardados correctamente.");

            
            LimpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Operación cancelada.");

           
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtReferencia.Text = "";
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtPrecioUni.Text = "";
            txtStock.Text = "";
            cmbEstado.SelectedIndex = -1;
        }

        
        private void txtReferencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtNombre.Focus();
            }
        }

    }

}


