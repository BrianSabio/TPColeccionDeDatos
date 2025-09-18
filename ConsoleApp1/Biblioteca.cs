using System;
using System.Collections;
using System.Collections.Generic;

namespace TPColeccionDeDatos
{
    internal class Biblioteca
    {
        private List<Lector> lectores;
        private List<Libro> libros;
        private List<Libro> librosPrestados;

        public Biblioteca() 
        {
            lectores = new List<Lector>();
            libros = new List<Libro>();
            librosPrestados = new List<Libro>();
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

        public bool altaLector(Lector lector)
        {
            bool resultado = false;
            foreach (var lectorExistente in lectores)
            {
                if (lectorExistente.Dni == lector.Dni)
                {
                    return resultado;
                }
            }
            lectores.Add(lector);
            return resultado = true;
        }

        public string prestarLibro(string titulo, int dniLector)
        {
            /*
            Posibles valores:

            "PRESTAMO EXITOSO" (en este caso el libro se le pudo 
            prestar al lector, se lo quitó de la lista de libros 
            que dispone la biblioteca y se lo adjudicó al lector)

            "LIBRO INEXISTENTE" (cuando el libro no se encuentra dentro 
            de la colección de libros en la biblioteca)

            "TOPE DE PRESTAMO ALCAZADO" (cuando el lector ya 
            posee tres libros en préstamo)

            "LECTOR INEXISTENTE" (cuando el lector no es se encuentra 
            registrado dentro de la colección de lectores en la biblioteca)
            */
        }
    }
}
