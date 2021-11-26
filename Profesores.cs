using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3BFacultad
{
    class Profesores : Persona
    {
        static public string Nombre;
        static public string Apellido;
        static public int Num_Identificacion;
        static public string Estado_Civil;

        //Ingresamos los datos personale
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
        // Ingresamos los dato de la falcultad
        public void Incorporacion()
        {
            Console.Clear();
            Console.WriteLine("Ingrese su año de incorporacion a la facultad: ");
            string Incorporacion = Console.ReadLine();
            Console.WriteLine("Ingrese su numero de despacho tienen asignado: ");
            int Despacho = int.Parse(Console.ReadLine());
        }
        //Podemos elegir departamento que pertenecemos
        public void Departamento()
        {
            Console.Clear();
            int departa;
            Console.WriteLine("Elija que departamento pertenecen : \nLenguajes-----1 \nMatematicas-----2 \nArquitectura-----3");
            departa = int.Parse(Console.ReadLine());
            if (departa == 1)
            {
                Console.WriteLine("Pertenece al departamento de Lenguajes");
            }
            else if (departa == 2)
            {
                Console.WriteLine("Pertenece al departamento de Matematicas");
            }
            else if (departa == 3)
            {
                Console.WriteLine("Pertenece al departamento de Arquitectura");
            }
        }
        public void despacho()
        {
            Console.Clear();
            int nuevodep;
            string despacho;
            Console.WriteLine("Ingrese su despacho:");
            despacho = Console.ReadLine();
            Console.WriteLine("Si desea reasignaser a un nuevo despacho elija\n Si---->1\n No---->2");
            nuevodep = int.Parse(Console.ReadLine());
            if (nuevodep == 1)
            {
                Console.WriteLine("Ingrese su nuevo reasignacion de despacho:");
                despacho = Console.ReadLine();
                Console.WriteLine("Su nueva reasignacion de despacho es:" + despacho);
            }
            else
            {
                Console.WriteLine("Su despacho sigue igual :"+despacho);

            }
        }
    }
}
