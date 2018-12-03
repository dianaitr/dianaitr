using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIA_DianaTorres_JoseGalvis
{
    public partial class InterfazPrincipal : Form
    {
        private VentanaReestricciones reestricciones;
        private VentanaInstrucciones instrucciones;
       
        private Jugador jugador;

       
        public InterfazPrincipal()
        {
            InitializeComponent();
            instrucciones = new VentanaInstrucciones(this);
            
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            if (!comboApodo.Text.Equals(""))
            {
                jugador = new Jugador(comboApodo.Text);


                reestricciones = new VentanaReestricciones(this, jugador);
                reestricciones.Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Ingrese un apodo porfavor.");
            }
             

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {

            instrucciones.Visible = true;
            this.Visible = false;

        }
    }
}
