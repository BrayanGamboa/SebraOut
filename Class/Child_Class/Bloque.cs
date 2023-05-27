using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebraOut
{
    public class Bloque : Elemento_Grafico
    {
        private int dureza;
        

        public int Dureza { get => dureza; set => dureza = value; }


        public Bloque(int x, int y, string nombre, int height, int width, int dureza) : base(x, y, nombre, height, width)
        {
            this.Dureza = dureza;

        }

    }
}
