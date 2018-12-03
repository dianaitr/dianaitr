using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIA_DianaTorres_JoseGalvis
{
    public class Juego
    {
        private Jugador jugador;
        private List<Piedra> monton;

        private int restriccionParaQuitar;

        private int cantidadFinal;

        private bool ganaLaUltimaPiedra;
        private bool empiezaPc;

        public bool EmpiezaPc { get => empiezaPc; set => empiezaPc = value; }

        public List<Piedra> getMonton()
        {
            return monton;
        }

        public void setMonton(List<Piedra> monton)
        {
            this.monton = monton;
        }

        public Jugador getJugador()
        {
            return jugador;
        }

        public void setJugador(Jugador jugador)
        {
            this.jugador = jugador;
        }



        public Juego(int numPiedras, String apodoJugador, int laRestriccionParaQuitar, 
            int laCantidadFinal, bool condicionParaGanar,bool empiezaPc)
        {

            jugador = new Jugador(apodoJugador);
            monton = new List<Piedra>();
            int altura = 500;
            for (int i = 0; i < numPiedras; i++)
            {
                Piedra p = new Piedra(75, altura-=25);
                monton.Add(p);
            }
            setRestriccion(laRestriccionParaQuitar);
            ganaLaUltimaPiedra = condicionParaGanar;
            setCantidadFinal(laCantidadFinal);
            EmpiezaPc = empiezaPc;

        }

        public void turnoComputador()
        {

            int n = monton.Count;

            bool cond = false;

            int actual = 0;

            if (ganaLaUltimaPiedra)
            {

                actual = cantidadFinal + 1;
            }
            else
            {


                actual = cantidadFinal;
            }



            int siguiente = 0;

            while (!cond)
            {
                double r1 = restriccionParaQuitar;
                double r2 = restriccionParaQuitar - 1;
                double arg = (double)actual * (r1 / r2);
                siguiente = (int)arg + 1;
                if (siguiente > n)
                {
                    cond = true;
                }
                else
                {
                    actual = siguiente;
                }
            }

            int cantidad = n - actual;

            cond = quitarPiedras(cantidad);

            while (!cond)
            {
                cond = quitarPiedras(n);
                n--;
            }
        }

        public bool turnoJugador(int cantidad)
        {
            return quitarPiedras(cantidad);
        }

        public bool recibirDatosTurnoJugador(int x,int y)
        {
            bool r = false;
            bool r1 = false;
            int contador = 0;
            for(int i = 0; i < monton.Count && !r; i++)
            {
                Piedra p = monton.ElementAt(i);
                int topeX = 250;
                int topeY = p.posY + 30;
                if(x>p.posX && x < topeX)
                {
                    if(y>p.posY && y < topeY)
                    {
                        contador++;
                        r = true;
                        r1 = quitarPiedras(contador);
                    }
                }
            }


            return r&&r1;
        }

        public int cantidadMaximaQuePuedeQuitar()
        {
            return monton.Count / restriccionParaQuitar;
        }

        private bool quitarPiedras(int cantidad)
        {
            int cantidadMaxima = monton.Count / restriccionParaQuitar;
            if (cantidad > cantidadMaxima)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < cantidad; i++)
                {
                    monton.RemoveAt(monton.Count - 1);
                }
                return true;
            }

        }

        public bool isGanaLaUltimaPiedra()
        {
            return ganaLaUltimaPiedra;
        }

        public void setGanaLaUltimaPiedra(bool ganaLaUltimaPiedra)
        {
            this.ganaLaUltimaPiedra = ganaLaUltimaPiedra;
        }

        public double getRestriccion()
        {
            return restriccionParaQuitar;
        }

        public void setRestriccion(int restriccion)
        {
            this.restriccionParaQuitar = restriccion;
        }

        public int getCantidadFinal()
        {
            return cantidadFinal;
        }

        public void setCantidadFinal(int cantidadFinal)
        {
            this.cantidadFinal = cantidadFinal;
        }
    }
}

