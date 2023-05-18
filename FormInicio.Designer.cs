namespace SebraOut
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
            this.label1 = new System.Windows.Forms.Label();
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelNivel = new System.Windows.Forms.Panel();
            this.BoxNivel = new System.Windows.Forms.ComboBox();
            this.btnNivel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnJugar = new System.Windows.Forms.Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtNombres = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelLateral.SuspendLayout();
            this.panel3.SuspendLayout();
            this.PanelNivel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Location = new System.Drawing.Point(8, 0);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(192, 67);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "SebraOut";
            // 
            // PanelLateral
            // 
            this.PanelLateral.AutoScroll = true;
            this.PanelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.PanelLateral.Controls.Add(this.panel3);
            this.PanelLateral.Controls.Add(this.PanelNivel);
            this.PanelLateral.Controls.Add(this.panel1);
            this.PanelLateral.Controls.Add(this.PanelLogo);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(200, 491);
            this.PanelLateral.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Location = new System.Drawing.Point(0, 379);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 67);
            this.panel3.TabIndex = 2;
            // 
            // PanelNivel
            // 
            this.PanelNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelNivel.Controls.Add(this.BoxNivel);
            this.PanelNivel.Controls.Add(this.btnNivel);
            this.PanelNivel.Location = new System.Drawing.Point(3, 230);
            this.PanelNivel.Name = "PanelNivel";
            this.PanelNivel.Size = new System.Drawing.Size(197, 99);
            this.PanelNivel.TabIndex = 2;
            // 
            // BoxNivel
            // 
            this.BoxNivel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BoxNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxNivel.FormattingEnabled = true;
            this.BoxNivel.Location = new System.Drawing.Point(45, 46);
            this.BoxNivel.Name = "BoxNivel";
            this.BoxNivel.Size = new System.Drawing.Size(121, 24);
            this.BoxNivel.TabIndex = 2;
            // 
            // btnNivel
            // 
            this.btnNivel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNivel.FlatAppearance.BorderSize = 0;
            this.btnNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNivel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNivel.Location = new System.Drawing.Point(0, 0);
            this.btnNivel.Name = "btnNivel";
            this.btnNivel.Size = new System.Drawing.Size(197, 40);
            this.btnNivel.TabIndex = 1;
            this.btnNivel.Text = "NIVELES";
            this.btnNivel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.btnJugar);
            this.panel1.Location = new System.Drawing.Point(0, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 67);
            this.panel1.TabIndex = 1;
            // 
            // btnJugar
            // 
            this.btnJugar.FlatAppearance.BorderSize = 0;
            this.btnJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnJugar.Location = new System.Drawing.Point(4, 4);
            this.btnJugar.Margin = new System.Windows.Forms.Padding(4);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(192, 54);
            this.btnJugar.TabIndex = 0;
            this.btnJugar.Text = "JUGAR";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.PanelLogo.Controls.Add(this.label1);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(200, 100);
            this.PanelLogo.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panel4.Controls.Add(this.txtNombres);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.ForeColor = System.Drawing.Color.Coral;
            this.panel4.Location = new System.Drawing.Point(200, 391);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(451, 100);
            this.panel4.TabIndex = 4;
            // 
            // txtNombres
            // 
            this.txtNombres.AutoSize = true;
            this.txtNombres.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNombres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtNombres.ForeColor = System.Drawing.Color.Snow;
            this.txtNombres.Location = new System.Drawing.Point(0, 84);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(323, 16);
            this.txtNombres.TabIndex = 0;
            this.txtNombres.Text = "Desarrollado por : Brayan Gamboa , Sebastian Diaz .";
            this.txtNombres.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(200, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(451, 391);
            this.panel5.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::SebraOut.Properties.Resources.Picture;
            this.pictureBox1.Location = new System.Drawing.Point(21, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(651, 491);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.PanelLateral);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.PanelLateral.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.PanelNivel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PanelNivel;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label txtNombres;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNivel;
        private System.Windows.Forms.ComboBox BoxNivel;
    }
}