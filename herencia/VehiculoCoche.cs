using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class VehiculoCoche:Vehiculo
    {
        public VehiculoCoche() { }

        public VehiculoCoche(int iD_Vehiculo, string marca, string modelo, int año, int puertas)
        : base(iD_Vehiculo,marca, modelo, año)
        {
            Puertas = puertas;
        }

        public int Puertas { get; set; }

    }
}
