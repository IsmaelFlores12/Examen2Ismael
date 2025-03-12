using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Examen2Ismael
{
    internal class Acciones
    {
        public List <Libros> listaLibros=new List <Libros> ();
        Libros L = new Libros ();

        public void agregar()
        {
            Console.WriteLine("Nombre: ");
            L.Nombre=Console.ReadLine ();
            Console.WriteLine("Autor:");
            L.Autor=Console.ReadLine ();
            Console.WriteLine("Año: ");
            L.Áño=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Precio: ");
            L.Precio=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Editorial");
            L.Editorial=Console.ReadLine ();

            listaLibros.Add (new Libros(L.Nombre,L.Autor,L.Áño,L.Precio,L.Editorial));
        }
        public void Mostrar()
        {
            foreach (var L in listaLibros)
            {
                Console.WriteLine("Libros disponibles:");
                Console.WriteLine($"Nombre del libro: {L.Nombre}");
                Console.WriteLine($"Autor: {L.Autor}");
                Console.WriteLine($"Año: {L.Áño}");
                Console.WriteLine($"Precio: {L.Precio}");
                Console.WriteLine($"Editorial{L.Editorial}");

            }
        }
        public void Eliminar(String NombreL)
        {
            var Libro = listaLibros.FirstOrDefault(x => x.Nombre == NombreL);
            if (Libro == null)
                listaLibros.Remove(Libro);
            else
                Console.WriteLine("No se encontro articulo");
        }
        public void actualizar(string Nombre)
        {
            var Libro = listaLibros.FirstOrDefault(x => x.Nombre == Nombre);
            if (Libro != null)
            {
                Console.WriteLine("Ingrese los nuevos datos");
                Console.WriteLine("Nombre:");
                L.Nombre = Console.ReadLine();

                Console.WriteLine("Autor:");
                L.Autor = Console.ReadLine();

                Console.WriteLine("Año:");
                L.Áño=Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Precio:");
                L.Precio=Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Editorial:");
                L.Editorial=Console.ReadLine();
            }
        }
    }
}
