using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIA_DianaTorres_JoseGalvis
{
   public class Jugador
    {

        private String apodo;

        public String getApodo()
        {
            return apodo;
        }

        public void setApodo(String apodo)
        {
            this.apodo = apodo;
        }

        public Jugador(String a)
        {
            apodo = a;
        }
    }
}
