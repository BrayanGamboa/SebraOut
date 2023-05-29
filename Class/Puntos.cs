using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SebraOut
{
    internal class Puntos
    {
        public Puntos () { }
  
        private int id = 0, puntaje = 0;

        public int Id { get => id; set => id = value; }
        public int Puntaje { get => puntaje; set => puntaje = value; }        

        public Puntos(int id, int puntaje)
        {
            this.Id = id;
            this.Puntaje = puntaje;
        }
    }
}
