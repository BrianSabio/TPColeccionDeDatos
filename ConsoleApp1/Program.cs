using System;

namespace TPColeccionDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.agregarLibro("Jorge", "AutorEjemplo", "EditorialEjemplo");
            biblioteca.altaLector("Brian Sabio", 38298279);
            biblioteca.altaLector("Pedre Buetemente", 38986239);
            biblioteca.listarLectores();
        }
    }
}