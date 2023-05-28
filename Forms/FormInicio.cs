using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SebraOut
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (BoxNivel.Text == "")
            {
                MessageBox.Show("Seleccione el nivel de difiultad", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (BoxNivel.Text == "Nivel 1")
                {
                    Nivel1 Juego = new Nivel1();
                    Juego.Show();
                    this.Hide();
                }
                else
                {
                    Nivel2 Juego = new Nivel2();
                    Juego.Show();
                    this.Hide();
                }
            }
        }

        private void btnPuntaje_Click(object sender, EventArgs e)
        {
            Puntaje puntaje = new Puntaje();
            puntaje.Show();
            this.Hide();
        }
    }
}
