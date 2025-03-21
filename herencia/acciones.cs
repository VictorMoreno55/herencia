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
        public void ContarCoche()
        {
            
        }
        public void EliminarCoche()
        {
            Console.WriteLine("Dame ID a eliminar");
            int id = Convert.ToInt32(Console.ReadLine());
            DiccCoche.Remove(id);
        }
        public void ActualizarCoche(string nombremarcas)
        {
            Console.WriteLine("Dame ID");
            int ID = Convert.ToInt32(Console.ReadLine());
            
            var coche = DiccCoche.FirstOrDefault(x => x.Value.ID_Vehiculo == ID);

            Console.WriteLine("Dame nuevo ID");
            coche.Value.ID_Vehiculo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame Marca");
            coche.Value.Marca = Console.ReadLine();
            Console.WriteLine("Dame Modelo");
            coche.Value.Modelo = Console.ReadLine();
            Console.WriteLine("Dame Año");
            coche.Value.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame Puertas");
            coche.Value.Puertas = Convert.ToInt32(Console.ReadLine());


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
        public void EliminarCaminion()
        {
            Console.WriteLine("Dame ID a eliminar");
            int id = Convert.ToInt32(Console.ReadLine());
            DiccCamion.Remove(id);
        }
        public void ActualizarCamion(string nombremarca)
        {
            Console.WriteLine("Dame ID");
            int ID = Convert.ToInt32(Console.ReadLine());

            var Camion = DiccCamion.FirstOrDefault(x => x.Value.ID_Vehiculo == ID);

            Console.WriteLine("Dame nuevo ID");
            Camion.Value.ID_Vehiculo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame Marca");
            Camion.Value.Marca = Console.ReadLine();
            Console.WriteLine("Dame Modelo");
            Camion.Value.Modelo = Console.ReadLine();
            Console.WriteLine("Dame Año");
            Camion.Value.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame Puertas");
            Camion.Value.CapacidadDeCarga = Convert.ToInt32(Console.ReadLine());

        }
    }

}
