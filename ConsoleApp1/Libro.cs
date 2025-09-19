using System;
using System.Collections.Generic;

namespace TPColeccionDeDatos
{
    internal class Libro
    {
        public string Titulo { get; }
        private string Autor { get; }
        private string Editorial { get; }

        public Libro(string titulo, string autor, string editorial)
        {
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
        }

        public override string ToString()
        {
            return $"Libro {{ Titulo: '{Titulo}', Autor: '{Autor}', Editorial: '{Editorial}' }}";
        }
    }
}