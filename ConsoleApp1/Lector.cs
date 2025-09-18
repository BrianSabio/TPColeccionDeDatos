using System;
using System.Collections.Generic;

namespace TPColeccionDeDatos
{
    internal class Lector
    {
        internal string Nombre { get; }
        internal int Dni { get; }
        private List<Libro> librosPrestados;

        public Lector(string nombre, int dni)
        {
            Nombre = nombre;
            Dni = dni;
        }

        public void listarLibros()
        {
            Console.WriteLine("Libros prestados: ");
            foreach (Libro libro in librosPrestados)
            {
                Console.WriteLine(libro.ToString());
            }
        }
    }
}