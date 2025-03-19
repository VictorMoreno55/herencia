using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class acciones
    {
        private List<Alumno> Lista = new List<Alumno>();
        Alumno a = new Alumno();

        public void AddStudent()
        {
            Lista.Add(new Alumno(a.Nombre,a.Edad,a.Genero,a.Matricula,a.Carrera));
        }
    }
}
