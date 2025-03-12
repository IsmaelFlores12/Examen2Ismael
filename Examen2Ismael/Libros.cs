using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2Ismael
{
    internal class Libros
    {
       
       public Libros() { }

        public Libros(string nombre, string autor, int áño, double precio, string editorial)
        {
            Nombre = nombre;
            Autor = autor;
            Áño = áño;
            Precio = precio;
            Editorial = editorial;
        }

        public string Nombre { get; set; }
        public string Autor { get; set; }
        public int Áño { get; set; }
        public double Precio { get; set; }
        public string Editorial { get; set; }
    }
}
