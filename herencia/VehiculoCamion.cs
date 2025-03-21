using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace herencia
{
    internal class VehiculoCamion:Vehiculo
    {
        public VehiculoCamion() { }

        public VehiculoCamion(int iD_Vehiculo, string marca, string modelo, int año, int capacidadDeCarga)
        :base(iD_Vehiculo, marca, modelo, año)
        {
            CapacidadDeCarga = capacidadDeCarga;
        }

        public int CapacidadDeCarga { get; set; }
    }
}
