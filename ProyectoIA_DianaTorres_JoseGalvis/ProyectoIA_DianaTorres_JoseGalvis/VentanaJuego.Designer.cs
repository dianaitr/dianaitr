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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaJuego));
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
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "PC vs Apodo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(94, 572);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(119, 43);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(0, 572);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 43);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelJuego
            // 
            this.panelJuego.BackColor = System.Drawing.SystemColors.Window;
            this.panelJuego.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelJuego.Location = new System.Drawing.Point(262, 45);
            this.panelJuego.Margin = new System.Windows.Forms.Padding(4);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.Size = new System.Drawing.Size(195, 557);
            this.panelJuego.TabIndex = 6;
            this.panelJuego.Paint += new System.Windows.Forms.PaintEventHandler(this.panelJuego_Paint);
            this.panelJuego.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelJuego_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(2, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de piedras : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(2, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad máxima a retirar :";
            // 
            // lblCantidadMaximaQuitar
            // 
            this.lblCantidadMaximaQuitar.AutoSize = true;
            this.lblCantidadMaximaQuitar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCantidadMaximaQuitar.Location = new System.Drawing.Point(180, 55);
            this.lblCantidadMaximaQuitar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadMaximaQuitar.Name = "lblCantidadMaximaQuitar";
            this.lblCantidadMaximaQuitar.Size = new System.Drawing.Size(16, 17);
            this.lblCantidadMaximaQuitar.TabIndex = 2;
            this.lblCantidadMaximaQuitar.Text = "0";
            // 
            // lblCantidadPiedras
            // 
            this.lblCantidadPiedras.AutoSize = true;
            this.lblCantidadPiedras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCantidadPiedras.Location = new System.Drawing.Point(149, 21);
            this.lblCantidadPiedras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadPiedras.Name = "lblCantidadPiedras";
            this.lblCantidadPiedras.Size = new System.Drawing.Size(16, 17);
            this.lblCantidadPiedras.TabIndex = 4;
            this.lblCantidadPiedras.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblCantidadPiedras);
            this.panel2.Controls.Add(this.lblCantidadMaximaQuitar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(10, 212);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 93);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnTurnoJugador
            // 
            this.btnTurnoJugador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTurnoJugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnoJugador.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTurnoJugador.Location = new System.Drawing.Point(13, 342);
            this.btnTurnoJugador.Margin = new System.Windows.Forms.Padding(4);
            this.btnTurnoJugador.Name = "btnTurnoJugador";
            this.btnTurnoJugador.Size = new System.Drawing.Size(126, 43);
            this.btnTurnoJugador.TabIndex = 8;
            this.btnTurnoJugador.Text = "Quitar Piedras";
            this.btnTurnoJugador.UseVisualStyleBackColor = false;
            this.btnTurnoJugador.Click += new System.EventHandler(this.btnTurnoJugador_Click);
            // 
            // btnTurnoPC
            // 
            this.btnTurnoPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTurnoPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurnoPC.ForeColor = System.Drawing.SystemColors.Window;
            this.btnTurnoPC.Location = new System.Drawing.Point(13, 425);
            this.btnTurnoPC.Margin = new System.Windows.Forms.Padding(4);
            this.btnTurnoPC.Name = "btnTurnoPC";
            this.btnTurnoPC.Size = new System.Drawing.Size(126, 43);
            this.btnTurnoPC.TabIndex = 9;
            this.btnTurnoPC.Text = "Turno PC";
            this.btnTurnoPC.UseVisualStyleBackColor = false;
            this.btnTurnoPC.Click += new System.EventHandler(this.btnTurnoPC_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(146, 352);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(30, 24);
            this.txtCantidad.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.SystemColors.Window;
            this.labelInfo.Location = new System.Drawing.Point(3, 64);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(180, 15);
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
            this.lblCantidadPasada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadPasada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCantidadPasada.Location = new System.Drawing.Point(181, 64);
            this.lblCantidadPasada.Name = "lblCantidadPasada";
            this.lblCantidadPasada.Size = new System.Drawing.Size(41, 15);
            this.lblCantidadPasada.TabIndex = 0;
            this.lblCantidadPasada.Text = "label3";
            this.lblCantidadPasada.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(1, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "¿Gana a quien le quede la última?";
            // 
            // lblQuienGana
            // 
            this.lblQuienGana.AutoSize = true;
            this.lblQuienGana.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuienGana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblQuienGana.Location = new System.Drawing.Point(201, 10);
            this.lblQuienGana.Name = "lblQuienGana";
            this.lblQuienGana.Size = new System.Drawing.Size(41, 15);
            this.lblQuienGana.TabIndex = 0;
            this.lblQuienGana.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(2, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Proporción que puede quitar:";
            // 
            // lblProporcion
            // 
            this.lblProporcion.AutoSize = true;
            this.lblProporcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProporcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblProporcion.Location = new System.Drawing.Point(189, 37);
            this.lblProporcion.Name = "lblProporcion";
            this.lblProporcion.Size = new System.Drawing.Size(41, 15);
            this.lblProporcion.TabIndex = 0;
            this.lblProporcion.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(168, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "1 /";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(3, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Cantidad Final:";
            // 
            // lblCantidadFinal
            // 
            this.lblCantidadFinal.AutoSize = true;
            this.lblCantidadFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCantidadFinal.Location = new System.Drawing.Point(95, 94);
            this.lblCantidadFinal.Name = "lblCantidadFinal";
            this.lblCantidadFinal.Size = new System.Drawing.Size(46, 18);
            this.lblCantidadFinal.TabIndex = 11;
            this.lblCantidadFinal.Text = "label3";
            this.lblCantidadFinal.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.panel1.Location = new System.Drawing.Point(10, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 117);
            this.panel1.TabIndex = 0;
            // 
            // VentanaJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(468, 615);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}