using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejem2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwElementos.Items.Add(elem);//de esta manera podre agregar a la lista todos los items que queira
        }

        private void rbNegro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cboColorFavorito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //de esta manera cargue al combo box 
            cboColorFavorito.Items.Add("Verder");
            cboColorFavorito.Items.Add("Azul");
            cboColorFavorito.Items.Add("Amarillo");
            cboColorFavorito.Items.Add("Rojo");
        }

        private void labelColor_Click(object sender, EventArgs e)
        {

        }

        private void butVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            //Operador Ternario
            string chocolate = ckbChocolate.Checked == true ? "Le gusta el Chocolate": "Odia el Chocolate";
            string elegir = groupBoxTipo.Text;
            //de esta manero selecciono tipo
            string tipo;
            if (rbBlanco.Checked)
            {
                tipo = "Blanco";
            }
            else
                tipo = "Negro";
            //color favorito
            string colorFavorito = cboColorFavorito.SelectedItem.ToString();//selecteditem selecciona lo que esta seleccionado y devuelve un objeto
            string numeroFavorito = num.Value.ToString();//ToString transforma el valor que sea en string 

                string mensaje = chocolate + ", es "+ tipo + ", sucolor es "+ colorFavorito + ", su numero Favorito es "+ numeroFavorito;
                MessageBox.Show("Nombre " + nombre + " Fecha" + fecha + ", " + mensaje);
        }
    }
}
