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
        Paleta paleta;

        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Muro();
            Load_Bloque();
            Load_Paleta();

        }

        private void Load_Muro()
        {
            var psc = LeerArchivo("Muro_Coordenadas");
            for (int i = 0; i < psc.GetLength(0); i++)
            {
                Bloque muro = new Bloque(psc[i, 1], psc[i, 0], "Pared_2", 20, 20, 300);
                Muros.Add(muro);
                this.Controls.Add(muro.Img_Element);
            }

        }

        private void Load_Paleta() {
            paleta = new Paleta(120, 380, "Linea");
            this.Controls.Add(paleta.Img_Element);
        }
        private void Load_Bloque()
        {
            Random Num_Random = new Random();
            var psc = LeerArchivo("Bloque_Coordenadas");
            for (int i = 0; i < psc.GetLength(0); i++)
            {
                int num_Aleatorio = Num_Random.Next(1, 6);

                Bloque bloque = new Bloque(psc[i, 0], psc[i, 1], Indicador_Nombre(num_Aleatorio),16 ,20, num_Aleatorio*2);
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

        private string Indicador_Nombre(int posicion)
        {
            //Es la encargada de traducir de un número int a un nombre en especial

            Dictionary<int, string> nombreImg = new Dictionary<int, string>
            {
                {1, "Bloque_Amarillo"},
                {2, "Bloque_Verde"},
                {3, "Bloque_Azul"},
                {4, "Bloque_Rojo"},
                {5, "Bloque_Morado"}
            };


            return nombreImg[posicion];
        }

        private int Indicador_Dureza( int num)
        {
            //Es la encargada de traducir de un número int a un nombre en especial

            Dictionary<int, int> dureza = new Dictionary<int, int>
            {
                {1, 2},
                {2, 4},
                {3, 6},
                {4, 8},
                {5, 10 }
            };


            return dureza[num];

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            c = char.ToUpper(c);
            if (c == 'D')
            {
                paleta.MoverRight();
            }
            else if (c == 'A')
            {


                paleta.MoverLeft();
            }
        }
    }
}
