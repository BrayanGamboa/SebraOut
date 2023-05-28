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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            ConnectionDB connection = new ConnectionDB();

            usuario.Nombre = nombre_U.Text;
            usuario.Apellido = apellido_U.Text;
            usuario.Email = correo_U.Text;
            usuario.Puntos = 0;
            int respuesta = connection.New_Usuario(usuario);
            if (respuesta == 1)
            {
                MessageBox.Show("¡Usuario Registrado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            FormInicio formInicio = new FormInicio();
            formInicio.Show();
            this.Hide();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio();
            formInicio.Show();
            this.Hide();
        }
    }
}
