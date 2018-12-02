using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIA_DianaTorres_JoseGalvis
{
   public  class Piedra
    {

        private int posX, posY;
        private bool movimiento;


        public Piedra(int x, int y)
        {
            posX = x;
            posY = y;
            movimiento = false;
        }


        public bool isEstado()
        {
            return movimiento;
        }


        public void setEstado(bool estado)
        {
            this.movimiento = estado;
        }
    }
}
