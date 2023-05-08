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
    public partial class Form1 : Form
    {

        Elemento_Grafico elemento_Grafico;
        List<Elemento_Grafico> Bloques = new List<Elemento_Grafico>();
        List<Elemento_Grafico> Muros = new List<Elemento_Grafico>();


        public Form1()
        {
            InitializeComponent();
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Muro();
            Load_Bloque();

        }

        private void Load_Muro()
        {
            var psc = LeerArchivo("Muro_Coordenadas");
            for (int i = 0; i < psc.GetLength(0); i++)
            {
                Bloque muro = new Bloque(psc[i, 1], psc[i, 0], "Pared_2");
                Muros.Add(muro);
                this.Controls.Add(muro.Img_Element);
            }

        }
        private void Load_Bloque()
        {
            var psc = LeerArchivo("Bloque_Coordenadas");
            for (int i = 0; i < psc.GetLength(0); i++)
            {
                Bloque bloque = new Bloque(psc[i, 0], psc[i, 1],"boque");
                Bloques.Add(bloque);
                this.Controls.Add(bloque.Img_Element);
            }

        }

        private int[,] LeerArchivo(string nombreArchivo)
        {
            var coor = (String)Properties.Resources.ResourceManager.GetObject(nombreArchivo);
            string[] arrayCoor = coor.Split(',');
            int[,] posiciones = new int[arrayCoor.Length, 2];
            for (int i = 0; i < arrayCoor.Length; i++)
            {
                arrayCoor[i] = arrayCoor[i].Trim('\n');
                var strCoor = arrayCoor[i].Split(':');
                posiciones[i, 0] = int.Parse(strCoor[0]);
                posiciones[i, 1] = int.Parse(strCoor[1]);
            }

            return posiciones;


        }


    }
}
