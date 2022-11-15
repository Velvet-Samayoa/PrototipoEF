using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_Bancos
{
    public partial class NuevaPoliza : Form
    {
        Seguridad_Controlador.Controlador cnseg = new Seguridad_Controlador.Controlador();
        public NuevaPoliza()
        {
            InitializeComponent();
         
         

        }

     /*   private void navegador1_Load_1(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "7003";
            TextBox[] Grupotextbox = { txt_nopoli,txt_fechapoli,txt_descpoli,txt_ctapoli,txt_elepoli,txt_debe,txt_haber};
            TextBox[] Idtextbox = { txt_nopoli, txt_fechapoli };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "tbl_polizasbancarias");
        }
     */
       
        

        private void gestionCartelerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cartelera c = new Cartelera();
            c.Show();
        }

        private void bitacorasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
