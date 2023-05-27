namespace SebraOut
{
    partial class Nivel2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nivel2));
            this.N_vidas = new System.Windows.Forms.Label();
            this.puntaje = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // N_vidas
            // 
            this.N_vidas.AutoSize = true;
            this.N_vidas.BackColor = System.Drawing.Color.Transparent;
            this.N_vidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.N_vidas.ForeColor = System.Drawing.Color.Chartreuse;
            this.N_vidas.Location = new System.Drawing.Point(12, 422);
            this.N_vidas.Name = "N_vidas";
            this.N_vidas.Size = new System.Drawing.Size(133, 24);
            this.N_vidas.TabIndex = 1;
            this.N_vidas.Text = "Vidas restante:";
            // 
            // puntaje
            // 
            this.puntaje.AutoSize = true;
            this.puntaje.BackColor = System.Drawing.Color.Transparent;
            this.puntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntaje.ForeColor = System.Drawing.Color.Chartreuse;
            this.puntaje.Location = new System.Drawing.Point(223, 422);
            this.puntaje.Name = "puntaje";
            this.puntaje.Size = new System.Drawing.Size(78, 24);
            this.puntaje.TabIndex = 2;
            this.puntaje.Text = "Puntaje:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Nivel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(370, 455);
            this.Controls.Add(this.puntaje);
            this.Controls.Add(this.N_vidas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nivel2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SebraOut - Nivel 2";
            this.Load += new System.EventHandler(this.Nivel2_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label N_vidas;
        private System.Windows.Forms.Label puntaje;
        private System.Windows.Forms.Timer timer1;
    }
}