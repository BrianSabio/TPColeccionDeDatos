using System;

namespace TPColeccionDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.agregarLibro("Jorge", "AutorEjemplo", "EditorialEjemplo");
            biblioteca.altaLector("Brien Sabio", 34475574);
            biblioteca.altaLector("Pedre Bustamante", 35000001);
            biblioteca.listarLectores();
            biblioteca.prestarLibro("Jorge", 35000001);
            biblioteca.lectores[1].listarLibros();

        }
    }
}