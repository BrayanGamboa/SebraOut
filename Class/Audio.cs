using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace PacmanGame
{
    public class Audio
    {

        SoundPlayer player;


        public Audio() { }

        public void SeleccionarAudio(int audio)
        {
            switch (audio)
            {
                case 1:
                    player = new SoundPlayer(@"C:\Users\Usuario\OneDrive - pascualbravo.edu.co\Herramientas de programación\SebraOut\Resources\Game_Over.wav"); break;
                case 2:
                    player = new SoundPlayer(@"C:\Users\Usuario\OneDrive - pascualbravo.edu.co\Herramientas de programación\SebraOut\Resources\Win.wav"); break;
                    
                case 3:
                    player = new SoundPlayer(@"C:\Users\Usuario\OneDrive - pascualbravo.edu.co\Herramientas de programación\SebraOut\Resources\Rebote.wav"); break;
                default:
                    break;
            }

            player.Play();
        }
    }
}
