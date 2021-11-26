using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3BFacultad
{
    class Persona
    {
        private string Estudiante;
        private string Personal;
        private string Profesor;

        public void Escoger()
        {
            int Perso;
            Console.WriteLine("Escoja que persona viculada es en esta facultad: \nEstudiante-----1 \nProfesor-----2 \nPersonal de servicio-----3");
            Perso = int.Parse(Console.ReadLine());
            if (Perso == 1)
            {
                Console.WriteLine("Usted a escogido estudiantes");
                Estudiantes estudiantes = new Estudiantes();
                estudiantes.Ingresar();
                estudiantes.Matricular();
                estudiantes.Mostrar();
                estudiantes.NuevoCurso();
            }
            else if (Perso == 2)
            {
                Console.WriteLine("Usted a escogido profesor");
                Profesores profesores = new Profesores();
                profesores.Ingresar();
                profesores.Incorporacion();
                profesores.Departamento();
                int Tipo;
                Console.Clear();
                Console.WriteLine("Elija que tipo de profesor es: \nProfesores por contrato -----1 \nProfesores por nombramiento -----2");
                Tipo = int.Parse(Console.ReadLine());
                if (Tipo == 1)
                {
                    Profe_Contrato profe_Contrato = new Profe_Contrato();
                    profe_Contrato.Sueldo();
                }
                else if (Tipo == 2)
                {
                    Profe_Nombremiento profe_Nombremiento = new Profe_Nombremiento();
                    profe_Nombremiento.Calcular();
                }
                profesores.despacho();
            }
            else if (Perso == 3)
            {
                Console.WriteLine("Usted a escogido personal de servicio");
                Personal_Servicio persona_Servicio = new Personal_Servicio();
                persona_Servicio.Ingresar();
                persona_Servicio.Incorporacion();
                persona_Servicio.Mostrar();
                persona_Servicio.despacho();
                persona_Servicio.Asiganacion();
            }
          
        }
        public void Cambio()
        {
            int Cambio;
            Console.WriteLine("¿Desea hacerse un cambio de estodo civil?\nSi-----1\nNo-----2");
            Cambio = int.Parse(Console.ReadLine());
            if (Cambio == 1)
            {
                Console.Clear();
                int Estado;
                Console.WriteLine("Cambio del estado civil: \nSoltero-----1\nCasado-----2");
                Estado = int.Parse(Console.ReadLine());
                if (Estado == 1)
                {
                    Console.WriteLine("Su estado civil es Soltero");
                }
                else if (Estado==2)
                {
                    Console.WriteLine("Su esatdo civil es Casado");
                }
            }
            else
            {
                Console.WriteLine("Su estado civil sigue siendo el mismo");
            }
        } 


    }
}
    