using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BusinessLayer;

namespace AplicationLayer
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
           
        }

        public void guardarBD()
            {
                ClientesEntity cliente = new ClientesEntity();
               
                cliente.NumeroDocumento = txtdocumento.Text;
                cliente.Primerombre = txtprimernombre.Text;
               
                cliente.PrimerApellido = txtprimerapellido.Text;
                
                cliente.Telefono = txtnumero.Text;
                cliente.Email = txtemail.Text;

                if (clienteBusines.GuardarCliente(cliente))
                {
                    MessageBox.Show("Usuario guardado con exito");
                }
            LimpiarFormulario();

         
    }

        private void LimpiarFormulario() {
            txtdocumento.Text = "";
            txtprimernombre.Text = "";
            txtprimerapellido.Text = "";
            txtnumero.Text = "";
            txtemail.Text = "";
        
        }


        private void txtTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ADIOS CRACK");
            Application.Exit();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            guardarBD();
           
        }

     
    }
}
