using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SebraOut
{ 
    public class Pelota : Elemento_Grafico
    {
        private float velocidad;
        private float angulo;
        private int velx, vely;
        public int Velocidad_X { get => velx; set => velx = value; }
        public int Velocidad_Y { get => vely; set => vely = value; }
        public float Velocidad { get => velocidad; set => velocidad = value; }
        public float Angulo { get => angulo; set => angulo = value; }

        public Pelota(int x, int y, string nombre) : base(x, y, nombre, 15, 15)
        {
            Velocidad = 6;
            // Ángulo de salida
            angulo = 30; 
        }



        public void Mover(Rectangle areaJuego)
        {
            // Calcula la suma de los movimieto en X y Y según el ángulo que resulta
            float velocidadX = velocidad * (float)Math.Cos(angulo * Math.PI / 180);
            float velocidadY = -velocidad * (float)Math.Sin(angulo * Math.PI / 180);

            // Calcula la nueva posición de la pelota
            int nuevaPosX = Psc_X + (int)velocidadX;
            int nuevaPosY = Psc_Y + (int)velocidadY;

            // Verifica la colisión con los muros superiores
            if (nuevaPosY < areaJuego.Top)
            {
                // Ajusta la posición de la pelota para que no atraviese los muros superiores
                nuevaPosY = areaJuego.Top;
                // Cambia la dirección vertical de la pelota
                CambiarDireccionY();
            }

            // Actualiza la posición de la pelota
            Psc_X = nuevaPosX;
            Psc_Y = nuevaPosY;

            // Verifica la colisión con los muros laterales
            if (nuevaPosX < areaJuego.Left || nuevaPosX + 14 > areaJuego.Right)
            {
                // Cambia la dirección horizontal de la pelota
                CambiarDireccionX();
            }

            // Actualiza la posición visual de la pelota
            Change_psc(Psc_X, Psc_Y);
        }


        public void CambiarDireccionX()
        {
            angulo = 180 - angulo; // Invierte el ángulo horizontalmente
        }

        public void CambiarDireccionY()
        {
            angulo = -angulo; // Invierte el ángulo verticalmente
        }

        public bool Evaluar_Colision(Elemento_Grafico objetos)
        {
            if (objetos.Get_Rectangle().IntersectsWith(this.Get_Rectangle()))
            {
                return true;
            }
            return false;
        }
        public bool Evaluar_Colision(List<Elemento_Grafico> objetos)
        {
            for (int i = 0; i < objetos.Count; i++)
            {
                if (objetos[i].Get_Rectangle().IntersectsWith(this.Get_Rectangle()))
                {
                    return true;
                }
            }
            return false;
        }
        public bool Evaluar_Colision(List<Bloque> objetos)
        {
            for (int i = 0; i < objetos.Count; i++)
            {
                if (objetos[i].Get_Rectangle().IntersectsWith(this.Get_Rectangle()))
                {
                    return true;
                }
            }
            return false;
        }

        public void Resetear()
        {
            Psc_X = 180; // Restablece la posición X de la pelota
            Psc_Y = 360; // Restablece la posición Y de la pelota
            velocidad = 6; // Restablece la velocidad de la pelota
            angulo = 45; // Restablece el ángulo de movimiento de la pelota
            Change_psc(Psc_X, Psc_Y); // Actualiza la posición visual de la pelota
        }
    }
}
