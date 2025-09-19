using System;
using System.Collections.Generic;

namespace TPColeccionDeDatos
{
    internal class Lector
    {
        internal string Nombre { get; }
        internal int Dni { get; }
        internal List<Libro> librosEnPosesion { get; }

        public Lector(string nombre, int dni)
        {
            Nombre = nombre;
            Dni = dni;
            librosEnPosesion = new List<Libro>();
        }

        public void listarLibros()
        {
            Console.WriteLine("Libros en posesión: ");
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