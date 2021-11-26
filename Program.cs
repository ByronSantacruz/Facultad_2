using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3BFacultad
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Escoger();
            persona.Cambio();
            Console.ReadLine();
            Profesores profesores = new Profesores();
        }
    }
}
