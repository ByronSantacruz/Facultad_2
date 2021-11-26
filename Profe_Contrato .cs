using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3BFacultad
{
    class Profe_Contrato : Profesores
    {
        private string Datos;
        private int Precio_Hora;
        private int Horas_Trabajadas;

        public void Sueldo()
        {
            Console.Clear();
            Console.Write(("Ingrese el precio de horas trabajadas: "));
            int Precio_Hora = int.Parse(Console.ReadLine());
            Console.Write(("Ingrese las horas trabajadas de este mes: "));
            int Horas_Trabajos = int.Parse(Console.ReadLine());
            int Calcular = Precio_Hora * Horas_Trabajos;
            Profesores profesores = new Profesores();
            Console.Clear();
            Console.WriteLine("Un gusto " +Nombre+ " se bienveido\nNumero de indentificacion "+ Num_Identificacion);
            Console.WriteLine("Su estado civil es: " + Estado_Civil);
            Console.WriteLine("Su sueldo es de : " + Calcular);
        }
    }
}
