﻿namespace Juego_OCA
{
    partial class FormInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picturebOCA = new System.Windows.Forms.PictureBox();
            this.btnResponder = new System.Windows.Forms.Button();
            this.txtRespuesta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturebOCA)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Blue;
            this.btnSalir.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(339, 450);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(282, 85);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.BackColor = System.Drawing.Color.Red;
            this.btnJugar.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.ForeColor = System.Drawing.Color.White;
            this.btnJugar.Location = new System.Drawing.Point(339, 348);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(282, 85);
            this.btnJugar.TabIndex = 10;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = false;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Reality Hyper", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Juego de la OCA";
            // 
            // picturebOCA
            // 
            this.picturebOCA.BackColor = System.Drawing.Color.Transparent;
            this.picturebOCA.Image = ((System.Drawing.Image)(resources.GetObject("picturebOCA.Image")));
            this.picturebOCA.Location = new System.Drawing.Point(367, 38);
            this.picturebOCA.Name = "picturebOCA";
            this.picturebOCA.Size = new System.Drawing.Size(225, 225);
            this.picturebOCA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturebOCA.TabIndex = 7;
            this.picturebOCA.TabStop = false;
            // 
            // btnResponder
            // 
            this.btnResponder.BackColor = System.Drawing.Color.Black;
            this.btnResponder.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponder.ForeColor = System.Drawing.Color.White;
            this.btnResponder.Location = new System.Drawing.Point(140, 94);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(117, 35);
            this.btnResponder.TabIndex = 13;
            this.btnResponder.Text = "¡Responder!";
            this.btnResponder.UseVisualStyleBackColor = false;
            // 
            // txtRespuesta
            // 
            this.txtRespuesta.Location = new System.Drawing.Point(58, 94);
            this.txtRespuesta.Name = "txtRespuesta";
            this.txtRespuesta.Size = new System.Drawing.Size(65, 20);
            this.txtRespuesta.TabIndex = 12;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 632);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.txtRespuesta);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picturebOCA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInicio";
            ((System.ComponentModel.ISupportInitialize)(this.picturebOCA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picturebOCA;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.TextBox txtRespuesta;
    }
}