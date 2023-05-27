namespace SebraOut
{
    partial class Nivel1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nivel1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.puntaje = new System.Windows.Forms.Label();
            this.N_vidas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // puntaje
            // 
            this.puntaje.AutoSize = true;
            this.puntaje.BackColor = System.Drawing.Color.Transparent;
            this.puntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntaje.ForeColor = System.Drawing.Color.Chartreuse;
            this.puntaje.Location = new System.Drawing.Point(229, 438);
            this.puntaje.Name = "puntaje";
            this.puntaje.Size = new System.Drawing.Size(78, 24);
            this.puntaje.TabIndex = 1;
            this.puntaje.Text = "Puntaje:";
            // 
            // N_vidas
            // 
            this.N_vidas.AutoSize = true;
            this.N_vidas.BackColor = System.Drawing.Color.Transparent;
            this.N_vidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N_vidas.ForeColor = System.Drawing.Color.Chartreuse;
            this.N_vidas.Location = new System.Drawing.Point(12, 438);
            this.N_vidas.Name = "N_vidas";
            this.N_vidas.Size = new System.Drawing.Size(133, 24);
            this.N_vidas.TabIndex = 0;
            this.N_vidas.Text = "Vidas restante:";
            // 
            // Nivel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(370, 471);
            this.Controls.Add(this.puntaje);
            this.Controls.Add(this.N_vidas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nivel1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SebraOut - Nivel 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label puntaje;
        private System.Windows.Forms.Label N_vidas;
    }
}