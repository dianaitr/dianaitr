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
    public partial class VentanaReestricciones : Form
    {
        private InterfazPrincipal interfazPrincipal;
        private VentanaJuego ventanaJuego;

        private Juego juego;
        private Jugador jugador;

        public VentanaReestricciones(InterfazPrincipal interfazPrincipal, Jugador jugador)
        {
            InitializeComponent();
            this.interfazPrincipal = interfazPrincipal;
            this.jugador = jugador;
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            bool c1 =false;
            string s = comboQuienGana.Text;
            if (s.Equals("Si"))
            {
                c1 = true;
            }
            else if(s.Equals("No"))
            {
                c1 = false;
            }

            
            bool c2=false;
            s = comboQuienEmpieza.Text;
            if (s.Equals("Yo Empiezo"))
            {
                c2 = false;
            }
            else if (s.Equals("Empieza PC"))
            {
                c2 = true;
            }



            juego = new Juego(Int32.Parse(txtNumPiedras.Text), jugador.getApodo(), Int32.Parse(txtProporcionMax.Text),
                Int32.Parse(txtCantidadParaGanar.Text), c1, c2);


            ventanaJuego = new VentanaJuego(this,juego);
            ventanaJuego.Visible = true;
            this.Visible = false;
        }
    }
}
