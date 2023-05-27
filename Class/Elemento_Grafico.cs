using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SebraOut
{
    public class Elemento_Grafico
    {
        private int psc_X, psc_Y;
        private PictureBox img_Element;
        private string name_img;


        public Elemento_Grafico(int x, int y, string nombre, int h, int w)
        {
            this.Psc_X = x;
            this.Psc_Y = y;
            this.Name_img= nombre;
            this.Img_Element = new PictureBox();
            this.Img_Element.Size = new Size(w, h);
            this.Img_Element.Location = new Point(x, y);
            this.Img_Element.Image = (Image)Properties.Resources.ResourceManager.GetObject(nombre);
            this.Img_Element.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Img_Element.BackColor = Color.Transparent;
        }

        public int Psc_X { get => psc_X; set => psc_X = value; }
        public int Psc_Y { get => psc_Y; set => psc_Y = value; }
        public PictureBox Img_Element { get => img_Element; set => img_Element = value; }
        public string Name_img { get => name_img; set => name_img = value; }

        public void Change_psc(int x, int y)
        {
            this.Psc_X = x;
            this.Psc_Y = y;
            this.Img_Element.Location = new Point(x, y);
        }


        public Rectangle Get_Rectangle()
        {
            return new Rectangle(Psc_X, Psc_Y, Img_Element.Width, Img_Element.Height);
        }



    }
}
