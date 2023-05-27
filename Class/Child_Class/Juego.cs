using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebraOut
{
    public class Juego
    {
        private int puntaje = 0;
        private int num_Vidas = 3;

        public int Num_Vidas { get => num_Vidas; set => num_Vidas = value; }
        public int Puntaje { get => puntaje; set => puntaje = value; }

        public Juego()
        {

        }


    }
}
