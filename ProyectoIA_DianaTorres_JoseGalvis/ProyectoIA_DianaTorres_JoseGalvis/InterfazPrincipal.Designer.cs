﻿namespace ProyectoIA_DianaTorres_JoseGalvis
{
    partial class InterfazPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_1pila = new System.Windows.Forms.RadioButton();
            this.btn_npilas = new System.Windows.Forms.RadioButton();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnInfoNim = new System.Windows.Forms.Button();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Cúal es tu apodo?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "JUEGO DEL NIM";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(364, 198);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // btn_1pila
            // 
            this.btn_1pila.AutoSize = true;
            this.btn_1pila.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1pila.Location = new System.Drawing.Point(268, 269);
            this.btn_1pila.Name = "btn_1pila";
            this.btn_1pila.Size = new System.Drawing.Size(85, 28);
            this.btn_1pila.TabIndex = 3;
            this.btn_1pila.TabStop = true;
            this.btn_1pila.Text = "1 PILA";
            this.btn_1pila.UseVisualStyleBackColor = true;
            // 
            // btn_npilas
            // 
            this.btn_npilas.AutoSize = true;
            this.btn_npilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_npilas.Location = new System.Drawing.Point(375, 269);
            this.btn_npilas.Name = "btn_npilas";
            this.btn_npilas.Size = new System.Drawing.Size(101, 28);
            this.btn_npilas.TabIndex = 4;
            this.btn_npilas.TabStop = true;
            this.btn_npilas.Text = "N PILAS";
            this.btn_npilas.UseVisualStyleBackColor = true;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.Location = new System.Drawing.Point(308, 446);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(123, 34);
            this.btnAyuda.TabIndex = 5;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnInfoNim
            // 
            this.btnInfoNim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoNim.Location = new System.Drawing.Point(294, 497);
            this.btnInfoNim.Name = "btnInfoNim";
            this.btnInfoNim.Size = new System.Drawing.Size(154, 56);
            this.btnInfoNim.TabIndex = 6;
            this.btnInfoNim.Text = "Acerca del NIM";
            this.btnInfoNim.UseVisualStyleBackColor = true;
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpezar.Location = new System.Drawing.Point(299, 330);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(154, 58);
            this.btnEmpezar.TabIndex = 7;
            this.btnEmpezar.Text = "¡EMPEZAR!";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // InterfazPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 589);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.btnInfoNim);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btn_npilas);
            this.Controls.Add(this.btn_1pila);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InterfazPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton btn_1pila;
        private System.Windows.Forms.RadioButton btn_npilas;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnInfoNim;
        private System.Windows.Forms.Button btnEmpezar;
    }
}

