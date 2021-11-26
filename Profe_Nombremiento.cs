using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3BFacultad
{
    class Profe_Nombremiento : Profesores
    {
        private double sueldo =200.50;
        private double Horas;

        public void Calcular()
        {
            Console.Clear();
            Console.Write("Ingrese las horas extras trabajadas: \n");
            double Horas = double.Parse(Console.ReadLine());
            double Calcular = sueldo + Horas;
            Console.Clear();
            Console.WriteLine("Un gusto " + Nombre + " se bienveido\nNumero de indentificacion " + Num_Identificacion);
            Console.WriteLine("Usted tiene un sueldo fijo de 200,50");
            Console.WriteLine("Su estado civil es: " + Estado_Civil);
            Console.WriteLine("Su sueldo es de :" + Calcular);
        }
    }
}
