namespace ProyectoIA_DianaTorres_JoseGalvis
{
    partial class VentanaJuego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelJuego = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantidadMaximaQuitar = new System.Windows.Forms.Label();
            this.lblCantidadPiedras = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTurnoJugador = new System.Windows.Forms.Button();
            this.btnTurnoPC = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelNumPasado = new System.Windows.Forms.Label();
            this.lblCantidadPasada = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblQuienGana = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProporcion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCantidadFinal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gifPerdiste = new System.Windows.Forms.PictureBox();
            this.lblHasGanado = new System.Windows.Forms.Label();
            this.gifTrofeo = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gifPerdiste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifTrofeo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "PC vs Apodo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(6, 555);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(101, 32);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(857, 555);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 32);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelJuego
            // 
            this.panelJuego.BackColor = System.Drawing.Color.Transparent;
            this.panelJuego.Location = new System.Drawing.Point(377, 13);
            this.panelJuego.Margin = new System.Windows.Forms.Padding(4);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.Size = new System.Drawing.Size(155, 561);
            this.panelJuego.TabIndex = 6;
            this.panelJuego.Paint += new System.Windows.Forms.PaintEventHandler(this.panelJuego_Paint);
            this.panelJuego.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelJuego_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(27, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de piedras : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(-4, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad máxima a retirar :";
            // 
            // lblCantidadMaximaQuitar
            // 
            this.lblCantidadMaximaQuitar.AutoSize = true;
            this.lblCantidadMaximaQuitar.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadMaximaQuitar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCantidadMaximaQuitar.Location = new System.Drawing.Point(115, 107);
            this.lblCantidadMaximaQuitar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadMaximaQuitar.Name = "lblCantidadMaximaQuitar";
            this.lblCantidadMaximaQuitar.Size = new System.Drawing.Size(18, 18);
            this.lblCantidadMaximaQuitar.TabIndex = 2;
            this.lblCantidadMaximaQuitar.Text = "0";
            // 
            // lblCantidadPiedras
            // 
            this.lblCantidadPiedras.AutoSize = true;
            this.lblCantidadPiedras.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPiedras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCantidadPiedras.Location = new System.Drawing.Point(115, 42);
            this.lblCantidadPiedras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadPiedras.Name = "lblCantidadPiedras";
            this.lblCantidadPiedras.Size = new System.Drawing.Size(18, 18);
            this.lblCantidadPiedras.TabIndex = 4;
            this.lblCantidadPiedras.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblCantidadPiedras);
            this.panel2.Controls.Add(this.lblCantidadMaximaQuitar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(6, 88);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 152);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnTurnoJugador
            // 
            this.btnTurnoJugador.BackColor = System.Drawing.Color.Brown;
            this.btnTurnoJugador.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnoJugador.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTurnoJugador.Location = new System.Drawing.Point(14, 304);
            this.btnTurnoJugador.Margin = new System.Windows.Forms.Padding(4);
            this.btnTurnoJugador.Name = "btnTurnoJugador";
            this.btnTurnoJugador.Size = new System.Drawing.Size(153, 65);
            this.btnTurnoJugador.TabIndex = 8;
            this.btnTurnoJugador.Text = "Quitar Piedras";
            this.btnTurnoJugador.UseVisualStyleBackColor = false;
            this.btnTurnoJugador.Click += new System.EventHandler(this.btnTurnoJugador_Click);
            // 
            // btnTurnoPC
            // 
            this.btnTurnoPC.BackColor = System.Drawing.Color.Brown;
            this.btnTurnoPC.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnoPC.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTurnoPC.Location = new System.Drawing.Point(14, 377);
            this.btnTurnoPC.Margin = new System.Windows.Forms.Padding(4);
            this.btnTurnoPC.Name = "btnTurnoPC";
            this.btnTurnoPC.Size = new System.Drawing.Size(153, 65);
            this.btnTurnoPC.TabIndex = 9;
            this.btnTurnoPC.Text = "Turno PC";
            this.btnTurnoPC.UseVisualStyleBackColor = false;
            this.btnTurnoPC.Click += new System.EventHandler(this.btnTurnoPC_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.White;
            this.txtCantidad.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(174, 304);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(72, 65);
            this.txtCantidad.TabIndex = 0;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.labelInfo.Location = new System.Drawing.Point(8, 87);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(252, 15);
            this.labelInfo.TabIndex = 0;
            this.labelInfo.Text = "En el turno pasado se quitaron: ";
            // 
            // labelNumPasado
            // 
            this.labelNumPasado.AutoSize = true;
            this.labelNumPasado.Location = new System.Drawing.Point(71, 487);
            this.labelNumPasado.Name = "labelNumPasado";
            this.labelNumPasado.Size = new System.Drawing.Size(0, 18);
            this.labelNumPasado.TabIndex = 0;
            // 
            // lblCantidadPasada
            // 
            this.lblCantidadPasada.AutoSize = true;
            this.lblCantidadPasada.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPasada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCantidadPasada.Location = new System.Drawing.Point(300, 87);
            this.lblCantidadPasada.Name = "lblCantidadPasada";
            this.lblCantidadPasada.Size = new System.Drawing.Size(66, 18);
            this.lblCantidadPasada.TabIndex = 0;
            this.lblCantidadPasada.Text = "label3";
            this.lblCantidadPasada.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "¿Gana a quien le quede la última piedra?";
            // 
            // lblQuienGana
            // 
            this.lblQuienGana.AutoSize = true;
            this.lblQuienGana.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuienGana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblQuienGana.Location = new System.Drawing.Point(318, 10);
            this.lblQuienGana.Name = "lblQuienGana";
            this.lblQuienGana.Size = new System.Drawing.Size(66, 18);
            this.lblQuienGana.TabIndex = 0;
            this.lblQuienGana.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(3, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Proporción que puede quitar:";
            // 
            // lblProporcion
            // 
            this.lblProporcion.AutoSize = true;
            this.lblProporcion.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProporcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblProporcion.Location = new System.Drawing.Point(322, 51);
            this.lblProporcion.Name = "lblProporcion";
            this.lblProporcion.Size = new System.Drawing.Size(67, 18);
            this.lblProporcion.TabIndex = 0;
            this.lblProporcion.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(300, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "1 /";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(3, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(321, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cantidad restante para  ganar o perder:";
            // 
            // lblCantidadFinal
            // 
            this.lblCantidadFinal.AutoSize = true;
            this.lblCantidadFinal.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCantidadFinal.Location = new System.Drawing.Point(334, 117);
            this.lblCantidadFinal.Name = "lblCantidadFinal";
            this.lblCantidadFinal.Size = new System.Drawing.Size(66, 18);
            this.lblCantidadFinal.TabIndex = 11;
            this.lblCantidadFinal.Text = "label3";
            this.lblCantidadFinal.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblCantidadFinal);
            this.panel1.Controls.Add(this.lblQuienGana);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblCantidadPasada);
            this.panel1.Controls.Add(this.lblProporcion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(556, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 152);
            this.panel1.TabIndex = 0;
            // 
            // gifPerdiste
            // 
            this.gifPerdiste.BackColor = System.Drawing.Color.Transparent;
            this.gifPerdiste.Image = global::ProyectoIA_DianaTorres_JoseGalvis.Properties.Resources.GameOver;
            this.gifPerdiste.Location = new System.Drawing.Point(338, 206);
            this.gifPerdiste.Name = "gifPerdiste";
            this.gifPerdiste.Size = new System.Drawing.Size(554, 205);
            this.gifPerdiste.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gifPerdiste.TabIndex = 10;
            this.gifPerdiste.TabStop = false;
            this.gifPerdiste.Visible = false;
            // 
            // lblHasGanado
            // 
            this.lblHasGanado.AutoSize = true;
            this.lblHasGanado.BackColor = System.Drawing.Color.Transparent;
            this.lblHasGanado.Font = new System.Drawing.Font("Perpetua Titling MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasGanado.ForeColor = System.Drawing.SystemColors.Window;
            this.lblHasGanado.Location = new System.Drawing.Point(343, 234);
            this.lblHasGanado.Name = "lblHasGanado";
            this.lblHasGanado.Size = new System.Drawing.Size(497, 38);
            this.lblHasGanado.TabIndex = 11;
            this.lblHasGanado.Text = "¡Felicidades has ganado!";
            this.lblHasGanado.Visible = false;
            // 
            // gifTrofeo
            // 
            this.gifTrofeo.BackColor = System.Drawing.Color.Transparent;
            this.gifTrofeo.Image = global::ProyectoIA_DianaTorres_JoseGalvis.Properties.Resources.trophy;
            this.gifTrofeo.Location = new System.Drawing.Point(494, 275);
            this.gifTrofeo.Name = "gifTrofeo";
            this.gifTrofeo.Size = new System.Drawing.Size(189, 167);
            this.gifTrofeo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gifTrofeo.TabIndex = 12;
            this.gifTrofeo.TabStop = false;
            this.gifTrofeo.Visible = false;
            // 
            // VentanaJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = global::ProyectoIA_DianaTorres_JoseGalvis.Properties.Resources.madera;
            this.ClientSize = new System.Drawing.Size(969, 588);
            this.Controls.Add(this.gifTrofeo);
            this.Controls.Add(this.lblHasGanado);
            this.Controls.Add(this.gifPerdiste);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelNumPasado);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnTurnoPC);
            this.Controls.Add(this.btnTurnoJugador);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelJuego);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentanaJuego";
            this.Text = "VentanaJuego";
            this.Load += new System.EventHandler(this.VentanaJuego_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gifPerdiste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gifTrofeo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelJuego;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCantidadMaximaQuitar;
        private System.Windows.Forms.Label lblCantidadPiedras;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnTurnoJugador;
        private System.Windows.Forms.Button btnTurnoPC;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelNumPasado;
        private System.Windows.Forms.Label lblCantidadPasada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblQuienGana;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblProporcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCantidadFinal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox gifPerdiste;
        private System.Windows.Forms.Label lblHasGanado;
        private System.Windows.Forms.PictureBox gifTrofeo;
    }
}