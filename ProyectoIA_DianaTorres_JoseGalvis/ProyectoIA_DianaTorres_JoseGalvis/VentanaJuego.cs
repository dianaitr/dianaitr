﻿using System;
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
    public partial class VentanaJuego : Form
    {
        private VentanaReestricciones reestricciones;
        public VentanaJuego(VentanaReestricciones ventanaReestricciones)
        {
            InitializeComponent();
            reestricciones = ventanaReestricciones;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
            reestricciones.Visible = true;
            this.Visible = false;
        }
    }
}
