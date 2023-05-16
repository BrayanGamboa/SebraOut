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
            Form1 Juego = new Form1();
            Juego.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {


        }

    }
}
