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
            this.label2 = new System.Windows.Forms.Label();
            this.lblCantidadMaximaQuitar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelJuego = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCantidadPiedras = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "PC vs Apodo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad máxima a retirar :";
            // 
            // lblCantidadMaximaQuitar
            // 
            this.lblCantidadMaximaQuitar.AutoSize = true;
            this.lblCantidadMaximaQuitar.Location = new System.Drawing.Point(26, 131);
            this.lblCantidadMaximaQuitar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadMaximaQuitar.Name = "lblCantidadMaximaQuitar";
            this.lblCantidadMaximaQuitar.Size = new System.Drawing.Size(18, 20);
            this.lblCantidadMaximaQuitar.TabIndex = 2;
            this.lblCantidadMaximaQuitar.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de piedras : ";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(-2, 573);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(104, 43);
            this.btnRegresar.TabIndex = 4;
            this.btnRegresar.Text = "regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(843, 573);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(101, 43);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // panelJuego
            // 
            this.panelJuego.Location = new System.Drawing.Point(248, 52);
            this.panelJuego.Margin = new System.Windows.Forms.Padding(4);
            this.panelJuego.Name = "panelJuego";
            this.panelJuego.Size = new System.Drawing.Size(479, 550);
            this.panelJuego.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCantidadPiedras);
            this.panel2.Controls.Add(this.lblCantidadMaximaQuitar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 193);
            this.panel2.TabIndex = 7;
            // 
            // lblCantidadPiedras
            // 
            this.lblCantidadPiedras.AutoSize = true;
            this.lblCantidadPiedras.Location = new System.Drawing.Point(26, 41);
            this.lblCantidadPiedras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidadPiedras.Name = "lblCantidadPiedras";
            this.lblCantidadPiedras.Size = new System.Drawing.Size(18, 20);
            this.lblCantidadPiedras.TabIndex = 4;
            this.lblCantidadPiedras.Text = "0";
            // 
            // VentanaJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelJuego);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentanaJuego";
            this.Text = "VentanaJuego";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCantidadMaximaQuitar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelJuego;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCantidadPiedras;
    }
}