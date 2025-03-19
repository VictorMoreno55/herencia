using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class persona
    {
        public persona() { }
        public persona(string nombre, int edad, string genero)
        {
            Nombre = nombre;
            Edad = edad;
            Genero = genero;
        }

        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }

    }
}
