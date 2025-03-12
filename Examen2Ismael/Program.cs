using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Examen2Ismael
{
    internal class Program
    {
        public enum Menu
        {
            agregar = 1, Mostrar, eliminar, actializar
        }
        static void Main(string[] args)
        {
            Acciones acciones = new Acciones();
            while (true)
            {
                switch (menu())
                {
                    case Menu.agregar:
                        acciones.agregar();
                        break;
                    case Menu.Mostrar:
                        acciones.Mostrar();
                        break;
                    case Menu.eliminar:
                        Console.WriteLine("¿Qué libro deseas eliminar");
                        string nombre = Console.ReadLine();
                        break;
                    case Menu.actializar:
                        Console.WriteLine("Que Libros deseas actualizar");
                        string ActualizarL=Console.ReadLine();
                        acciones.actualizar(ActualizarL);

                        break;
                    default:
                        break;
                }
            }

        }
        static Menu menu()
        {
            Console.WriteLine("¿Qué opción deseas realizar?");
            Console.WriteLine("1) Agregar libro");
            Console.WriteLine("2) mostrar libros");
            Console.WriteLine("3) Eliminar libro");
            Console.WriteLine("4) Actualizar información");
            Menu opc =(Menu)Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}
