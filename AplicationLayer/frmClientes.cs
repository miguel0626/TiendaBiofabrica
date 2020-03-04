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
        public static bool  ProbarConexion()
        {
            if (.ProbarConexion()== true)
            {
                MessageBox.Show("Conexion Exitosa");
            }
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            CargarFechas();
           
        }

        public void guardarBD()
            {
                ClientesEntity cliente = new ClientesEntity();
                cliente.TipoDocumento = cbTipoDocumento.Text;
                cliente.NumeroDocumento = txtdocumento.Text;
                cliente.Primerombre = txtprimernombre.Text;
                cliente.SegundoNombre = txtsegundonombre.Text;
                cliente.PrimerApellido = txtprimerapellido.Text;
                cliente.SegudoApellido = txtsegundoapellido.Text;
                cliente.Telefono = txtnumero.Text;
                cliente.direccion = txtdireccion.Text;
                cliente.FechaNacimiento = Convert.ToDateTime(cbdia.Text + "," + cbmes.Text + "," + cbaño.Text);
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

        private void CargarFechas()
        {
            for (int dia = 1; dia <=31;  dia++)
            {
                cbdia.Items.Add(dia);
            }
            
            int aux = DateTime.Now.Year;

            for (int anyo = 1900; anyo <=2060 ; anyo++)
            {
                cbaño.Items.Add(anyo);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Validacion();
        }
        private bool Validacion() 
        {
            if (cbTipoDocumento.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("El tipo de documento es un dato obligatorio","Error validacion",MessageBoxButtons.OK,MessageBoxIcon.Error);
                cbTipoDocumento.Focus();
                return false;
            }
            if(txtdocumento.Text=="")
            {
                MessageBox.Show("El número de documento es un dato obligatorio", "Error validacion", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtdocumento.Focus();
                return false;
            }
            if(txtprimernombre.Text=="")
            {
                MessageBox.Show("El nombre es un dato obligatorio", "Error validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtprimernombre.Focus();
                return false;
            }
            if (txtprimerapellido.Text == "")
            {
                MessageBox.Show("El apellido es un dato obligatorio", "Error validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtprimerapellido.Focus();
                return false;
            }
            if (txtdireccion.Text == "")
            {
                MessageBox.Show("El apellido es un dato obligatorio", "Error validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdireccion.Focus();
                return false;
            }
            if (txtemail.Text == "")
            {
                MessageBox.Show("El apellido es un dato obligatorio", "Error validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtemail.Focus();
                return false;
            }
            if (txtnumero.Text =="")
            {
                MessageBox.Show("El número de telefono es un campo obligatorio","Error validacion", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            string MesAux = cbmes.Text;
            int YearAux = 0;
            int DiaAux = 0;
            Int32.TryParse(cbaño.Text, out YearAux);
            Int32.TryParse(cbdia.Text,out DiaAux);

            if(YearAux !=0)
            {
                if (DiaAux == 31 && MesAux == "Abril"||
                    DiaAux == 31 && MesAux == "Junio" ||
                    DiaAux == 31 && MesAux == "Septiembre"||
                    DiaAux == 31 && MesAux == "Noviembre")
                {
                    MessageBox.Show("Error");
                    return false;
                }
                if (DiaAux > 29 && MesAux == "Febrero")
                {
                    MessageBox.Show("Error");
                    return false;
                }
                if (DiaAux == 29 && MesAux == "Febrero")
                {
                    if (YearAux % 400 == 0 || (YearAux % 4 == 0 && YearAux % 100 != 0))
                    {
                        MessageBox.Show("Fecha Correcta");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Fecha incorrecta");
                        return false;
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Error");
                return false;
            }
            
            return true;
        }

            private void txtdocumento_KeyPress(object sender, KeyPressEventArgs e)
        { 
            if(!(char.IsNumber(e.KeyChar))&&(e.KeyChar !=(char)Keys.Back)&&(e.KeyChar !=(char)Keys.Enter))
            {
                MessageBox.Show("Ingrese unicamente números", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        
        
        
    }
}
