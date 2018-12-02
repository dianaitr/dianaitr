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
            juego=new Juego(Int32.Parse(txtNumPiedras.Text),jugador.getApodo,Int32.Parse(txtProporcionMax.Text),
                Int32.Parse(txtProporcionMax.Text),



            ventanaJuego = new VentanaJuego(this,juego);
            ventanaJuego.Visible = true;
            this.Visible = false;
        }
    }
}
