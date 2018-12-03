using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ProyectoIA_DianaTorres_JoseGalvis
{
    public partial class VentanaJuego : Form
    {
        private VentanaReestricciones reestricciones;
        private Juego juego;

        private bool turnoEsMio;

        private SoundPlayer sound;
        
        public VentanaJuego(VentanaReestricciones ventanaReestricciones, Juego juegi)
        {
            InitializeComponent();
            reestricciones = ventanaReestricciones;
            this.juego = juegi;
            
            lblCantidadMaximaQuitar.Text = juego.cantidadMaximaQuePuedeQuitar() + "";
            lblCantidadPiedras.Text = juego.getMonton().Count+"";
            label1.Text = "PC vs " + juego.getJugador().getApodo();
            pintarPiedras();
            if (juego.EmpiezaPc)
            {
                btnTurnoJugador.Enabled = false;
                btnTurnoJugador.BackColor = Color.DarkGray;
            }
            else
            {
                btnTurnoPC.Enabled = false;
                btnTurnoPC.BackColor = Color.DarkGray;
            }
            lblProporcion.Text = juego.getRestriccion()+"";
            if (juego.isGanaLaUltimaPiedra())
            {
                lblQuienGana.Text = "SI";
            }
            else
            {
                lblQuienGana.Text = "NO";
            }
            lblCantidadFinal.Text = juego.getCantidadFinal() + "";
            lblCantidadFinal.Visible = true;
        }

        private void pintarPiedras()
        {
            foreach (Piedra p in juego.getMonton())
            {
                PictureBox pb = new PictureBox();
                pb.Location = new Point(p.posX, p.posY);
                pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("piedra");
                pb.BackColor = Color.Transparent;
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Size=new Size(50, 25);
                panelJuego.Controls.Add(pb);
                
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            
            reestricciones.Visible = true;
            this.Visible = false;
        }

        private void panelJuego_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void panelJuego_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnTurnoPC_Click(object sender, EventArgs e)
        {
            int n1 = juego.getMonton().Count;
            juego.turnoComputador();
            int n2 = juego.getMonton().Count;
            int dif = n1 - n2;
            panelJuego.Controls.Clear();
            lblCantidadPasada.Text = dif + " piedras";
            pintarPiedras();
            btnTurnoPC.Enabled = false;
            btnTurnoPC.BackColor = Color.DarkGray;
            btnTurnoJugador.Enabled = true;
            btnTurnoJugador.BackColor = Color.Brown;
            lblCantidadPasada.Visible = true;
            lblCantidadMaximaQuitar.Text = juego.cantidadMaximaQuePuedeQuitar()+"";
            lblCantidadPiedras.Text = juego.getMonton().Count + "";
            turnoEsMio = true;
            verificarFinal();
            


        }

        private void btnTurnoJugador_Click(object sender, EventArgs e)
        {
            
            try
            {
                int c = Int32.Parse(txtCantidad.Text);
                int n1 = juego.getMonton().Count;
                bool cond = juego.turnoJugador(c);
                if (!cond || c==0)
                {
                    MessageBox.Show("Cantidad inválida");
                }
                else
                {
                    int n2 = juego.getMonton().Count;
                    int dif = n1 - n2;
                    panelJuego.Controls.Clear();
                    lblCantidadPasada.Text = dif + " piedras";
                    lblCantidadPasada.Visible = true;
                    pintarPiedras();
                    btnTurnoPC.Enabled = true;
                    btnTurnoPC.BackColor = Color.Brown;
                    btnTurnoJugador.BackColor = Color.DarkGray;
                    btnTurnoJugador.Enabled = false;
                    lblCantidadMaximaQuitar.Text = juego.cantidadMaximaQuePuedeQuitar() + "";
                    lblCantidadPiedras.Text = juego.getMonton().Count + "";
                    turnoEsMio = false;
                    verificarFinal();
                    

                }

                
                
            }
            catch 
            {
                MessageBox.Show("Cantidad inválida");
            }
            
            
            
        }

        private void verificarFinal()
        {
            
            
            if (juego.getMonton().Count == juego.getCantidadFinal() && juego.isGanaLaUltimaPiedra() 
                && !turnoEsMio)
            {
                sound.Stop();
                panelJuego.Controls.Clear();
                MessageBox.Show("¡HAS PERDIDO!");
                gifPerdiste.Visible = true;
                sound.Stop();
                sound.SoundLocation = "C:/Users/diana/source/repos/dianaitr/ProyectoIA_DianaTorres_JoseGalvis/ProyectoIA_DianaTorres_JoseGalvis/Properties/perdiste.wav";
                sound.Play();


            }
            else if (juego.getMonton().Count == juego.getCantidadFinal() && juego.isGanaLaUltimaPiedra()
                && turnoEsMio)
            {
                
                panelJuego.Controls.Clear();
                MessageBox.Show("¡FELICIDADES HAS GANADO!");
                lblHasGanado.Visible = true;
                sound.Stop();
                sound.SoundLocation = "C:/Users/diana/source/repos/dianaitr/ProyectoIA_DianaTorres_JoseGalvis/ProyectoIA_DianaTorres_JoseGalvis/Properties/ganaste.wav";
                sound.Play();
                gifTrofeo.Visible = true;

            }else if (juego.getMonton().Count == juego.getCantidadFinal() && !juego.isGanaLaUltimaPiedra()
                && !turnoEsMio) 
            {
                sound.Stop();
                panelJuego.Controls.Clear();
                sound.Stop();
                
                MessageBox.Show("¡FELICIDADES HAS GANADO!");
                lblHasGanado.Visible = true;


                gifTrofeo.Visible = true;
                sound.SoundLocation = "C:/Users/diana/source/repos/dianaitr/ProyectoIA_DianaTorres_JoseGalvis/ProyectoIA_DianaTorres_JoseGalvis/Properties/ganaste.wav";
                sound.Play();
            }
            else if(juego.getMonton().Count == juego.getCantidadFinal() && !juego.isGanaLaUltimaPiedra()
                && turnoEsMio)
            {
                sound.Stop();

                panelJuego.Controls.Clear();
                MessageBox.Show("¡HAS PERDIDO!");
                sound.Stop();
                sound.SoundLocation = "C:/Users/diana/source/repos/dianaitr/ProyectoIA_DianaTorres_JoseGalvis/ProyectoIA_DianaTorres_JoseGalvis/Properties/perdiste.wav";
                sound.Play();
                gifPerdiste.Visible = true;
            }


            
        }

        private void VentanaJuego_Load(object sender, EventArgs e)
        {
            sound = new SoundPlayer();
            sound.SoundLocation = "C:/Users/diana/source/repos/dianaitr/ProyectoIA_DianaTorres_JoseGalvis/ProyectoIA_DianaTorres_JoseGalvis/Properties/soundtrack.wav";
            sound.Play();
        }
    }
}
