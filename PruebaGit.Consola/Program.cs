using PruebaGit.Entidades;
using PruebaGit.Servicios;

namespace PruebaGit.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var servicio = new PersonaServicio();
            bool seguir = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Manejo de Personas para practica de Guit");
                Console.WriteLine("1 - Agregar");
                Console.WriteLine("2 - Borrar");
                Console.WriteLine("3 - Editar");
                Console.WriteLine("4 - Listar");
                Console.WriteLine("x - Salir");
                Console.Write("Ingrese opción:");
                string? opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "4":
                        ListarPersonas(servicio);
                        break;
                    case "x":
                        seguir = false;
                        break;
                    default:
                        break;
                }
            } while (seguir);
        }

        private static void ListarPersonas(PersonaServicio servicio)
        {
            Console.Clear();
            Console.WriteLine("Listado de Personas");
            foreach (Persona p in servicio.GetLista())
            {
                Console.WriteLine($"{p.Id} - {p.Nombre} {p.Apellido}");
            }
            Console.ReadLine();
        }
    }
}
