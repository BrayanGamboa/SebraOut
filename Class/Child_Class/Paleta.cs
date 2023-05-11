using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebraOut
{
    public class Paleta : Elemento_Grafico
    {
        private int velocidad = 6;

        public int Velocidad { get => velocidad; set => velocidad = value;}

        public Paleta(int x, int y, string nombre) : base(x, y, nombre, 15, 75)
        {
            
        }

        public void MoverRight()
        {
            Psc_X += velocidad;
            Change_psc(Psc_X, Psc_Y);
        }

        public void MoverLeft()
        {
            Psc_X -= velocidad;
            Change_psc(Psc_X, Psc_Y);
        }
    }
}
