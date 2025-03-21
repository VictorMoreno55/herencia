using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class acciones
    {
        Dictionary<int, VehiculoCoche> DiccCoche = new Dictionary<int, VehiculoCoche>();
        Dictionary<int, VehiculoCamion> DiccCamion = new Dictionary<int, VehiculoCamion>();
        VehiculoCoche vca = new VehiculoCoche();
        VehiculoCamion vco = new VehiculoCamion();


        public void AgregarCoche()
        {
            Console.WriteLine("Dame Matricula");
            int ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Marca");
            string Marca = Console.ReadLine();
            Console.WriteLine("Modelo");
            string Modelo = Console.ReadLine();
            Console.WriteLine("Año");
            int Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Puertas");
            int Puertas = Convert.ToInt32(Console.ReadLine());

            DiccCoche.Add(ID, new VehiculoCoche(vca.ID_Vehiculo, vca.Marca, vca.Modelo, vca.Año, vca.Puertas));
        }
        public void MostrarCoche()
        {
            foreach (var a in DiccCoche)
            {
                Console.WriteLine($"ID:{a.Value.ID_Vehiculo}");
                Console.WriteLine($"La Marca es: {a.Value.Marca}");
                Console.WriteLine($"El Modelo es: {a.Value.Modelo}");
                Console.WriteLine($"El año es: {a.Value.Año}");
                Console.WriteLine($"Tiene: {a.Value.Puertas} Puertas");
            }
        }
        public void AgregarCamion()
        {
            Console.WriteLine("Dame Matricula");
            int ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Marca");
            string Marca = Console.ReadLine();
            Console.WriteLine("Modelo");
            string Modelo = Console.ReadLine();
            Console.WriteLine("Año");
            int Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CapacidadDeCarga");
            int Puertas = Convert.ToInt32(Console.ReadLine());

            DiccCoche.Add(ID, new VehiculoCoche(vco.ID_Vehiculo, vco.Marca, vco.Modelo, vco.Año, vco.CapacidadDeCarga));
        }
        public void MostrarCamion()
        {
            foreach (var o in DiccCamion)
            {
                Console.WriteLine($"ID:{o.Value.ID_Vehiculo}");
                Console.WriteLine($"La Marca es: {o.Value.Marca}");
                Console.WriteLine($"El Modelo es: {o.Value.Modelo}");
                Console.WriteLine($"El año es: {o.Value.Año}");
                Console.WriteLine($"Tiene capacidad de carga: {o.Value.CapacidadDeCarga} ");
            }
        }
    }

}
