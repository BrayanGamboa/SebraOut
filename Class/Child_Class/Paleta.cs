using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebraOut
{
    internal class Paleta : Elemento_Grafico
    {
        private int velocidad;

        public int Velocidad { get => velocidad; set => velocidad = value;}

        public Paleta(int x, int y, string nombre, int h, int w, int velocidad) : base(x, y, nombre, h, w)
        {
            this.Velocidad = velocidad;
        }

        public void Move_left(){
            Psc_X -= 1;
        }

        public void Move_right()
        {
            Psc_X += 1;
        }

    }
}
