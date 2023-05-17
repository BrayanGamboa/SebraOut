using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebraOut
{
    internal class Pelota : Elemento_Grafico
    {
        private int velocidad = 5;
        
        



        public Pelota(int x, int y, string nombre) : base(x, y, nombre, 20, 20)
        {
            
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
