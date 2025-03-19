using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Alumno
    {
        public Alumno() { }

        public Alumno(int matricula, string carrera)
        {
            Matricula = matricula;
            Carrera = carrera;
        }

        public int Matricula { get; set; }
        public string Carrera { get; set; }
    }
}
