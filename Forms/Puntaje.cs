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
            lista_Puntaje.Columns.Add("Usuario", 130);
            
            lista_Puntaje.Columns.Add("Puntaje", 130);

            var lst_Puntaje = connection.List_Puntaje();

            for (int i = 0; i < lst_Puntaje.Count; i++)
            {
                lista_Puntaje.Items.Add(new ListViewItem(new[] { $"Usuario #{lst_Puntaje[i].Id}",
                    $"{lst_Puntaje[i].Puntaje}" }));
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
