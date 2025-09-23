
namespace TPColeccionDeDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.agregarLibro("El principito", "Antoine de Saint-Exupéry", "Reynal & Hitchcock");
            biblioteca.altaLector("Lionel Messi", 34475974);
            biblioteca.altaLector("Ricardo Darín", 84296254);
            biblioteca.listarLectores();
            biblioteca.prestarLibro("El principito", 34475974);
            biblioteca.lectores[0].listarLibros();

        }
    }
}