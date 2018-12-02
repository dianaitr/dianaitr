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

       

        public VentanaReestricciones(InterfazPrincipal interfazPrincipal)
        {
            InitializeComponent();
            this.interfazPrincipal = interfazPrincipal;
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            ventanaJuego = new VentanaJuego(this);
            ventanaJuego.Visible = true;
            this.Visible = false;
        }
    }
}
