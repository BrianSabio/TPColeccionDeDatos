using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;

namespace TPColeccionDeDatos
{
    internal class Biblioteca
    {
        private List<Lector> lectores;
        private List<Libro> libros;
        private List<Libro> librosDisponibles;

        public Biblioteca() 
        {
            lectores = new List<Lector>();
            libros = new List<Libro>();
            librosDisponibles = new List<Libro>();
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

            librosDisponibles = libros;

            Libro libro = buscarLibro(titulo);
            Lector lector = buscarLector(dniLector);

            if (lector != null && libro != null)
            {

                if (lector.librosEnPosesion.Count > 2)
                {
                    Console.WriteLine("TOPE DE PRESTAMO ALCANZADO");
                }
                else
                {
                    lector.librosEnPosesion.Add(libro);
                    librosDisponibles.Remove(libro);
                    Console.WriteLine("PRESTAMO EXITOSO");
                }

            } else if (lector == null)
            {
                Console.WriteLine("LECTOR INEXISTENTE");
            }
            else
            {
                Console.WriteLine("LIBRO INEXISTENTE");
            }
        }
    }
}
