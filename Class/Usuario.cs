using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SebraOut
{
    internal class Usuario
    {
        public Usuario () { }



        private string nombre, apellido, email;
        private int puntos = 0;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Email { get => email; set => email = value; }
        public int Puntos { get => puntos; set => puntos = value; }

        public Usuario(string nombre, string apellido, string email, int puntos = 0)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Puntos = puntos;
        }

        public Usuario(string nombre, string email, int puntos = 0)
        {
            this.Nombre = nombre;            
            this.Email = email;
            this.Puntos = puntos;
        }
    }
}
