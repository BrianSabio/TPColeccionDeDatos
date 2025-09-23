
namespace TPColeccionDeDatos
{
    internal class Biblioteca
    {
        internal List<Lector> lectores;
        private List<Libro> libros;

        public Biblioteca() 
        {

            lectores = new List<Lector>();
            libros = new List<Libro>();
        }

        private Libro buscarLibro(string titulo)
        {

            Libro libroBuscado = null;
            int i = 0;
            while (i < libros.Count && !libros[i].Titulo.Equals(titulo))
            {
                i++;
            }
            if (i != libros.Count)
            {
                libroBuscado = libros[i];
            }
            return libroBuscado;
        }

        public bool agregarLibro(string titulo, string autor, string editorial)
        {

            bool resultado = false;
            Libro libro = buscarLibro(titulo);
            if (libro == null)
            {
                libro = new Libro(titulo, autor, editorial);
                libros.Add(libro);
                resultado = true;
            }
            return resultado;
        }

        public void listarLibros()
        {

            foreach (Libro libro in libros)
            {
                Console.WriteLine(libro);
            }
        }

        public void listarLectores()
        {
            Console.WriteLine("Lista de lectores: ");
            foreach (Lector lector in lectores)
            {
                Console.WriteLine(lector);
            }
        }

        public bool eliminarLibro(string titulo)
        {

            bool resultado = false;
            Libro libro = buscarLibro(titulo);
            if(libro != null)
            {
                libros.Remove(libro);
                resultado = true;
            }
            return resultado;
        }

        private Lector buscarLector(int dni)
        {

            Lector lectorBuscado = null;
            int i = 0;
            while (i < lectores.Count && !lectores[i].Dni.Equals(dni))
            {
                i++;
            }
            if (i != lectores.Count)
            {
                lectorBuscado = lectores[i];
            }
            return lectorBuscado;
        }

        public bool altaLector(string nombre, int dni)
        {

            bool resultado = false;
            Lector lector = buscarLector(dni);
            if (lector == null)
            {
                lector = new Lector(nombre, dni);
                lectores.Add(lector);
                resultado = true;
            }
            return resultado;
        }

        public string prestarLibro(string titulo, int dniLector)
        {

            Libro libro = buscarLibro(titulo);
            Lector lector = buscarLector(dniLector);
            string resultado;

            if (lector != null && libro != null)
            {

                if (lector.librosEnPosesion.Count > 2)
                {
                    resultado = "\nTOPE DE PRÉSTAMO ALCANZADO";
                }
                else
                {
                    lector.librosEnPosesion.Add(libro);
                    libros.Remove(libro);
                    resultado = "\nPRÉSTAMO EXITOSO";
                }

            } else if (lector == null)
            {
                resultado = "\nLECTOR INEXISTENTE";
            }
            else
            {
                resultado = "\nLIBRO INEXISTENTE";
            }

            Console.WriteLine(resultado);
            return resultado;
        }
    }
}
