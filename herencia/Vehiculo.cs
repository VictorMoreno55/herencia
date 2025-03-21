using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Vehiculo
    {
        public Vehiculo() { }

        public Vehiculo(int iD_Vehiculo, string marca, string modelo, int año)
        {
            ID_Vehiculo = iD_Vehiculo;
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }

        public int ID_Vehiculo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }

    }
}
