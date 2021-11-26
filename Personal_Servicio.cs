using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByronSantacruz3BFacultad
{
    class Personal_Servicio : Persona
    {
        static private string Nombre;
        static private string Apellido;
        static private int Num_Identificacion;
        static private string Estado_Civil;
        private string Seccion;
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
        public void Incorporacion()
        {
            Console.Clear();
            Console.WriteLine("Ingrese su año de incorporacion a la facultad: ");
            string Incorporacion = Console.ReadLine();
            Console.WriteLine("Ingrese su numero de despacho tienen asignado: ");
            int Despacho = int.Parse(Console.ReadLine());
        }
        public void Asiganacion()
        {
            Console.Clear();
            int Asig;
            Console.WriteLine("Elija que seccion estan asignado : \nBiblioteca-----1 \nDecanato-----2 \nSecretaría-----3");
            Asig = int.Parse(Console.ReadLine());
            if (Asig == 1)
            {
                int Nuevo;
                Console.WriteLine("Su seccion asignado es Biblioteca");
                Console.WriteLine("¿Quiere cambiarse de seccion?");
                Nuevo = int.Parse(Console.ReadLine());
                if (Nuevo == 1)
                {
                    Console.WriteLine("Ingrese su nuevo seccion:");
                    Seccion = Console.ReadLine();
                    Console.WriteLine("Su nuevo seccion es:" + Seccion);
                }
                else
                {
                    Console.WriteLine("Su seccion sigue siendo Biblioteca");
                }
            }
            else if (Asig == 2)
            {
                int Nuevo;
                Console.WriteLine("Su seccion asignado es Decanato");
                Console.WriteLine("¿Quiere cambiarse de seccion?");
                Nuevo = int.Parse(Console.ReadLine());
                if (Nuevo == 1)
                {
                    Console.WriteLine("Ingrese su nuevo seccion:");
                    Seccion = Console.ReadLine();
                    Console.WriteLine("Su nuevo seccion es:" + Seccion);
                }
                else
                {
                    Console.WriteLine("Su seccion sigue siendo Decanato");
                }
            }
            else if (Asig == 3)
            {
                int Nuevo;
                Console.WriteLine("Su seccion asignado es Secretaría");
                Console.WriteLine("¿Quiere cambiarse de seccion?");
                Nuevo = int.Parse(Console.ReadLine());
                if (Nuevo == 1)
                {
                    Console.WriteLine("Ingrese su nuevo seccion:");
                    Seccion = Console.ReadLine();
                    Console.WriteLine("Su nuevo seccion es:" + Seccion);

                }
                else
                {
                    Console.WriteLine("Su seccion sigue siendo Secretaría");
                }
            }
        }
        public void Mostrar()
        {
            Console.WriteLine("Bienvendo personal de servio " + Nombre + " \nNumero de indentificacion " + Num_Identificacion);
            Console.WriteLine("Su estado civil es: " + Estado_Civil);
        }
        public void despacho()
        {
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
                Console.WriteLine("Su despacho sigue igual :" + despacho);
            }
        }
        public void Cambio()
        {
            
        }
    }
}
