using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace SebraOut
{
    public partial class Nivel1 : Form
    {
        List<Bloque> Bloques = new List<Bloque>();
        List<Elemento_Grafico> Muros = new List<Elemento_Grafico>();
        Paleta paleta;
        Pelota pelota;
        Juego juego = new Juego();

        public Nivel1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Muro();
            Load_Bloque();
            Load_Paleta();
            Load_Pelota();
            timer1.Start();            
        }

        private void Load_Muro()
        {
            var psc = LeerArchivo("Muro_Coordenadas");
            for (int i = 0; i < psc.GetLength(0); i++)
            {
                Bloque muro = new Bloque(psc[i, 1], psc[i, 0], "Pared_2", 18, 20, 300);
                Muros.Add(muro);
                this.Controls.Add(muro.Img_Element);
            }
        }

        private void Load_Paleta()
        {
            paleta = new Paleta(160, 380, "Linea");
            this.Controls.Add(paleta.Img_Element);

        }

        private void Load_Bloque()
        {
            Random Num_Random = new Random();
            var psc = LeerArchivo("Bloque_Coordenadas_N1");
            for (int i = 0; i < psc.GetLength(0); i++)
            {
                int num_Aleatorio = Num_Random.Next(1, 3);

                Bloque bloque = new Bloque(psc[i, 0], psc[i, 1], Indicador_Nombre(num_Aleatorio), 16, 20, num_Aleatorio);
                Bloques.Add(bloque);
                this.Controls.Add(bloque.Img_Element);
            }

        }

        private void Load_Pelota()
        {
            pelota = new Pelota(180, 360, "Circulo");
            this.Controls.Add(pelota.Img_Element);
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

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var c = e.KeyChar;
            c = char.ToUpper(c);

            switch (c)
            {
                case 'D':
                    if (paleta.Evaluar_Colision(Muros))
                        paleta.Rebote_Left(25);
                    else
                    {
                        paleta.Mover_Right();

                    }
                    break;
                case 'A':
                    if (paleta.Evaluar_Colision(Muros))
                        paleta.Rebote_Right(25);
                    else
                    {
                        paleta.Mover_Left();
                    }
                    break;
                default:
                    break;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            string vidas = "";
            for (int i = 0; i < juego.Num_Vidas; i++)
            {
                vidas += "❤️ ";
            }

            puntaje.Text = $"Puntaje: {juego.Puntaje}";
            N_vidas.Text = $"Vida restantes: {vidas}"; 
            pelota.Mover(this.ClientRectangle);

            // Verifica las colisiones con la paleta
            if (pelota.Evaluar_Colision(paleta))
            {
                // Cambia la dirección vertical de la pelota
                pelota.CambiarDireccionY();

                // Calcula el ángulo de rebote basado en la posición de impacto en la paleta
                float angulo = CalcularAnguloRebote(pelota, paleta);

                // Calcula las componentes de velocidad en X e Y según el ángulo de rebote
                float velocidadX = pelota.Velocidad * (float)Math.Cos(angulo);
                float velocidadY = -pelota.Velocidad * (float)Math.Sin(angulo);

                // Asigna las nuevas velocidades a la pelota
                pelota.Velocidad_X = Math.Sign(velocidadX);
                pelota.Velocidad_Y = Math.Sign(velocidadY);
            }            

            if (pelota.Evaluar_Colision(Bloques))
            {
                List<Bloque> bloquesEliminar = new List<Bloque>();

                for (int i = 0; i < Bloques.Count; i++)
                {
                    if (pelota.Evaluar_Colision(Bloques[i]))
                    {
                        pelota.CambiarDireccionY();
                        Bloques[i].Dureza--;
                        if (Bloques[i].Dureza == 0)
                        {
                            bloquesEliminar.Add(Bloques[i]);
                            juego.Puntaje++;
                        }
                    }
                }

                // Eliminar los bloques y sus elementos gráficos después del bucle
                foreach (Bloque bloqueEliminar in bloquesEliminar)
                {
                    Bloques.Remove(bloqueEliminar);
                    this.Controls.Remove(bloqueEliminar.Img_Element);
                }
            }


            

            // Verifica las colisiones con los muros
            if (pelota.Evaluar_Colision(Muros))
            {
                // Cambia la dirección horizontal de la pelota
                pelota.CambiarDireccionX();

                // Cambia la dirección vertical de la pelota

            }

            if (pelota.Psc_Y + 15 >= 420)
            {
                Perder();
            }

            if (Bloques.Count == 0)
            {
                Ganar();
            }

        }

        private float CalcularAnguloRebote(Pelota pelota, Paleta paleta)
        {
            //Calcula la posición relativa de impacto en la paleta (valor entre -1 y 1)
            float posicionImpacto = ((float)pelota.Psc_X - (float)paleta.Psc_X) / (float)paleta.Img_Element.Width;

            //Define el ángulo máximo de rebote (en radianes)
            float anguloMaximo = (float)(Math.PI / 3); // 60 grados

            //Calcula el ángulo de rebote basado en la posición relativa de impacto
            float anguloRebote = posicionImpacto * anguloMaximo;

            return anguloRebote;
        }

        private void Perder()
        {
            juego.Num_Vidas--;
            if (juego.Num_Vidas < 1)
            {
                timer1.Stop();
                GameOver gameOver = new GameOver();
                gameOver.Show();
                this.Hide();
            }
            else
            {
                this.Controls.Remove(paleta.Img_Element);
                this.Controls.Remove(pelota.Img_Element);


                // Restablece la posición y velocidad de lo objeto

                Load_Paleta();
                Load_Pelota();
                timer1.Start();
            }                        
        }
        
        private void Ganar()
        {
            timer1.Stop();
            MessageBox.Show("Feliitaciones pasate al nivel 2", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Nivel2 nivel2 = new Nivel2();
            nivel2.Show();
            this.Hide();
        }
    }
}
