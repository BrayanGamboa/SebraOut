using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SebraOut
{
    public class Paleta : Elemento_Grafico
    {
        private int velocidad = 5;

        public Paleta(int x, int y, string nombre) : base(x, y, nombre, 15, 75)
        {

        }

        public void Mover_Right()
        {
            Psc_X += velocidad;
            Change_psc(Psc_X, Psc_Y);
        }

        public void Mover_Left()
        {
            Psc_X -= velocidad;
            Change_psc(Psc_X, Psc_Y);
        }

        public void Rebote_Left(int vel_Rbt)
        {
            Psc_X -= vel_Rbt;
            Change_psc(Psc_X, Psc_Y);
        }
        public void Rebote_Right(int vel_Rbt)
        {
            Psc_X += vel_Rbt;
            Change_psc(Psc_X, Psc_Y);
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

        public bool Evaluar_Colision(Elemento_Grafico objetos)
        {
            if (objetos.Get_Rectangle().IntersectsWith(this.Get_Rectangle()))
            {
                return true;
            }
            return false;
        }
    }
}
