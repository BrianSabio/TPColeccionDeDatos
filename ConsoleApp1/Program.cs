using System;

namespace TPColeccionDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.agregarLibro("Jorge", "AutorEjemplo", "EditorialEjemplo");
            biblioteca.listarLibros();
        }
    }
}