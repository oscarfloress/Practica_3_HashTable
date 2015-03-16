using System;
using System.Collections;

namespace Practica_3_HashTable
{
    class ClasePrincipal
    {
        bool salir;
        private Hashtable hashtable;
        private Alumno alumno;

        ClasePrincipal()
        {
            salir = false;
            hashtable = new Hashtable();
            alumno = new Alumno();
        }

        public void menu()
        {
            int opcion;
            Console.WriteLine("1.- Agregar alumno");
            Console.WriteLine("2.- Eliminar alumno");
            Console.WriteLine("3.- Ver alumnos");
            Console.WriteLine("4.- Salir");
            Console.Write("\nElegir la opcion: ");
            try
            {
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1: agregarAlumno();
                        break;
                    case 2: eliminarAlumno();
                        break;
                    case 3: mostrarAlumno();
                        break;
                    case 4: Console.WriteLine("Bye");
                        salir = true;
                        break;
                    default: Console.WriteLine("Opcion invalida");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Debe ingresar un entero");
            }

        }

        public void agregarAlumno()
        {
            Console.Write("\nDame el codigo: ");
            alumno.setCodigo(Console.ReadLine());
            Console.Write("Dame el nombre: ");
            alumno.setNombre(Console.ReadLine());
            hashtable.Add(alumno.codigo, alumno.nombre);
        }

        public void eliminarAlumno()
        {
            if (hashtable.Count == 0)
            {
                Console.WriteLine("La tabla esta vacia");
                return;
            }
            Console.Write("Dame el codigo: ");
            string codigoEliminar = Console.ReadLine();
            char respuesta;
            if (hashtable.ContainsKey(codigoEliminar))
            {
                Console.WriteLine("\nCodigo: " + codigoEliminar);
                Console.WriteLine("Nombre: " + hashtable[codigoEliminar].ToString());
                Console.Write("\nDesea eliminar s/n? ");
                respuesta = char.Parse(Console.ReadLine());
                if (respuesta == 's' || respuesta == 'S')
                {
                    hashtable.Remove(codigoEliminar);
                    Console.WriteLine("\nRegistro eliminado");
                }
                else
                    Console.WriteLine("\nRegistro intacto");
            }
            else
                Console.WriteLine("No existe el codigo");
        }

        public void mostrarAlumno()
        {
            if (hashtable.Count == 0)
            {
                Console.WriteLine("La tabla esta vacia");
                return;
            }
            foreach (DictionaryEntry de in hashtable)
            {
                Console.WriteLine("\nCodigo: " + de.Key + "\nNombre: " + de.Value.ToString());
            }
        }

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "HashTable";
            Console.SetWindowSize(50, 30);
            ClasePrincipal principal = new ClasePrincipal();
            do
            {
                Console.Clear();
                principal.menu();
                Console.ReadKey();
            } while (!principal.salir);
        }
    }
}
