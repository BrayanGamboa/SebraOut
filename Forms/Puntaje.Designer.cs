﻿namespace SebraOut
{
    partial class Puntaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Puntaje));
            this.lista_Puntaje = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista_Puntaje
            // 
            this.lista_Puntaje.BackColor = System.Drawing.Color.Black;
            this.lista_Puntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_Puntaje.ForeColor = System.Drawing.Color.Lime;
            this.lista_Puntaje.HideSelection = false;
            this.lista_Puntaje.Location = new System.Drawing.Point(34, 71);
            this.lista_Puntaje.Name = "lista_Puntaje";
            this.lista_Puntaje.Size = new System.Drawing.Size(306, 306);
            this.lista_Puntaje.TabIndex = 0;
            this.lista_Puntaje.UseCompatibleStateImageBehavior = false;
            this.lista_Puntaje.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puntaje:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LawnGreen;
            this.button1.Location = new System.Drawing.Point(108, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Menú";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Puntaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(370, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista_Puntaje);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Puntaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puntaje";
            this.Load += new System.EventHandler(this.Puntaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lista_Puntaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}