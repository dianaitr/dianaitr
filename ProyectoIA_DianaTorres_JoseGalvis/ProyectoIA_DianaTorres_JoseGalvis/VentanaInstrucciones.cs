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
    public partial class VentanaInstrucciones : Form
    {
        InterfazPrincipal principal;
        public VentanaInstrucciones(InterfazPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            principal.Visible = true;
            this.Visible = false;
        }
    }
}
