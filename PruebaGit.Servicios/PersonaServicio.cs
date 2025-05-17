using PruebaGit.Datos;
using PruebaGit.Entidades;

namespace PruebaGit.Servicios
{
    public class PersonaServicio
    {
        private readonly PersonaRepositorio? personaRepositorio;
        public PersonaServicio()
        {
            personaRepositorio = new PersonaRepositorio();
        }
        public List<Persona> GetLista()
        {
            return personaRepositorio!.GetLista();
        }

    }
}
