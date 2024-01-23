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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //desde aqui are una vallidacion osea si ya esta abierto Form1 no lo abra otra ves
            //Application.OpenForms : dentro de OpenForms estaran todas las ventanads que esten habiertas
            //entonces como es una coleccion o lista, recorremos con FOREACH
            // Y si el item 
           foreach (var item in Application.OpenForms)
            {
                //si item osea de la vuelta actual
                //GetType te devuelve el tipo de objeto
                //si el tipo de objeto es igual a el tipo de objeto que busco 
                //typeof(Form1) :  tipo de objeto esto osea Form1
                //entonces retornamos 
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya está abierta esta ventana");
                    return;
                }
                //aclaracion si en dentro de mi formulario encuentro repetido este objeto se termina la ejecucion y no se avanza a lo de abajo
            }

            //de esta manera navego entre ventanas desde la opcion perfil persona
            //creo la intancia de un objeto 
            //lugo que se muestre con show y listo
            Form1 ventana = new Form1();
            //con midParent hago que la ventana del formulario no sea una ventana emergente 
            //sino que se abre dentro de la ventana padre 
            ventana.MdiParent = this;
            ventana.Show();//de esta manera navegara pero cada ves que yo precione el mismo boton se abrira mas ventanas de la misma 
            //ventana.ShowDialog();//esto va a evitar que habra mas venstanas igual, esto captura el momento 
        }

        private void toolStripPersona_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }
    }
}
