using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebraOut
{
    internal class Pelota : Elemento_Grafico
    {
        private int velocidad;
        
        public int Velocidad { get => velocidad; set => velocidad = value; }



        public Pelota(int x, int y, string nombre, int h, int w, int velocidad) : base(x, y, nombre, h, w)
        {
            this.Velocidad= velocidad;
        }

        public float Calculate_Angulo(int x, int y)
        {
            this.Psc_X= x;
            this.Psc_Y= y;

            double angleInRadians = Math.Atan2(y, x);
            double angleInDegrees = angleInRadians * 180 / Math.PI;

            return Convert.ToSingle(angleInDegrees);
        }

    }
}
