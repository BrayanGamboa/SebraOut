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
    public partial class Puntaje : Form
    {
        public Puntaje()
        {
            InitializeComponent();
        }

        ConnectionDB connection = new ConnectionDB();

        private void Puntaje_Load(object sender, EventArgs e)
        {
            lista_Puntaje.Columns.Add("Nombre", 130);
            lista_Puntaje.Columns.Add("Email", 130);
            lista_Puntaje.Columns.Add("Puntaje", 130);

            var list_Usuarios = connection.List_Usuarios();

            for (int i = 0; i < list_Usuarios.Count; i++)
            {
                lista_Puntaje.Items.Add(new ListViewItem(new[] { $"{list_Usuarios[i].Nombre}",
                    $"{list_Usuarios[i].Email}",$"{list_Usuarios[i].Puntos}" }));
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio();
            formInicio.Show();
            this.Hide();

        }
    }
}
