using System;
using System.Collections.Generic;

namespace TPColeccionDeDatos
{
    internal class Lector
    {
        internal string Nombre { get; }
        internal int Dni { get; }
        private List<Libro> librosEnPosesion;

        public Lector(string nombre, int dni)
        {
            Nombre = nombre;
            Dni = dni;
        }

        public void listarLibros()
        {
            Console.WriteLine("Libros prestados: ");
            foreach (Libro libro in librosEnPosesion)
            {
                Console.WriteLine(libro.ToString());
            }
        }

        public override string ToString()
        {
            return $"Lector {{Nombre: '{Nombre}', DNI: '{Dni}' }}";
        }
    }
}