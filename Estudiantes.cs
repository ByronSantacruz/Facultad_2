using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3BFacultad
{
    class Estudiantes : Persona
    {
        private string Nombre;
        private string Apellido;
        private int Num_Identificacion;
        private string Estado_Civil;
        private string Curso;

        public void Ingresar()
        {
            Console.Clear();
            Console.WriteLine("Ingrese su nombre y apellido");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su numero de identificacion: ");
            Num_Identificacion = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su estado civil: ");
            Estado_Civil = Console.ReadLine();
        }
        public void Matricular()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el curso en el que estan matriculados: ");
            Curso = Console.ReadLine();
        }
        public void Mostrar()
        {
            Console.WriteLine("Un gusto estudiante " + Nombre + " se bienveido a nuestra falcutad\nNumero de indentificacion " + Num_Identificacion);
            Console.WriteLine("Su estado civil es: " + Estado_Civil);
        }
        public void NuevoCurso()
        {
            Console.WriteLine("Su curso altual es :" + Curso);
            Console.WriteLine("Ingrese nuevo curso al cual se desea matricular");
            Curso = Console.ReadLine();
            Console.WriteLine("Usted fue asignado a este nuevo curso:" + Curso);
        }
    }
}
