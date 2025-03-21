using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Program
    {
        private enum Menu
        {
            AgregarCoche = 1, MostrarCoche, ContarCoche, EliminarCoche, ActualizarCoche, AgregarCamion, MostrarCamion, ContarCamion, EliminarCamion, ActualizarCamion
        }


        static void Main(string[] args)
        {
            acciones program = new acciones();
            while (true)
            {
                switch (Men())
                {
                    case Menu.AgregarCoche:
                        break;
                    case Menu.MostrarCoche:
                        break;
                    case Menu.ContarCoche:
                        break;
                    case Menu.EliminarCoche:
                        break;
                    case Menu.ActualizarCoche:
                        break;
                    case Menu.AgregarCamion:
                        break;
                    case Menu.MostrarCamion:
                        break;
                    case Menu.ContarCamion:
                        break;
                    case Menu.EliminarCamion:
                        break;
                    case Menu.ActualizarCamion:
                        break;
                    default:
                        break;
                }
            }

        }
        static Menu Men()
        {
            Console.WriteLine("¿Qué quieres hacer?");
            Console.WriteLine("1) Agregar Coche");
            Console.WriteLine("2) Mostrar Coche");
            Console.WriteLine("3) Contar Coche");
            Console.WriteLine("4) Eliminar Coche");
            Console.WriteLine("5) Actualizar Coche");
            Console.WriteLine("6) Agregar Camion");
            Console.WriteLine("7) Mostrar Camion");
            Console.WriteLine("8) Eliminar Camion");
            Console.WriteLine("9) Contar Camion");
            Console.WriteLine("10) Atualizar Camion");
            Menu opc = (Menu)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}


