using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtema4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string codigo="", carrera="", bienvenida="";
            do
            {
                Console.Clear();//limpia la consola por cada ejecución 
                Console.WriteLine("#######MENÚ DE OPCIONES########");
                Console.WriteLine("1.Leer código de estudiante y carrera.");
                Console.WriteLine("2.Formar una nueva etiqueta textual con ambos(concatenado).");
                Console.WriteLine("3.Mostrar longitud de caracteres del código, carrera y etiqueta.");
                Console.WriteLine("4.Mostrar el primer y último carácter del código.");
                Console.WriteLine("5.Imprimir la carrera carácter por carácter.");
                Console.WriteLine("6.Cree una nueva etiqueta de bienvenida agregando");
                Console.WriteLine("7. Sali del menú ");
                opcion = int.Parse(Console.ReadLine());// opcion 7, salir del menu 
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el código de estudiante: ");
                        codigo = Console.ReadLine();
                        Console.Write(" Carrera: ");
                        carrera = Console.ReadLine();
                        break;
                    case 2:
                        bienvenida = codigo + " | carrera: ";// concantenar unir ambas cadenas
                        Console.WriteLine("Etiqueta generada: " + bienvenida);
                        break;
                    case 3:                                 //N00123 = 7
                        Console.WriteLine("La longitud del codigo es: " + codigo.Length);
                        Console.WriteLine("La longitd de la carrera es: " + carrera.Length);
                        Console.WriteLine("La longitud del saludo es: " + bienvenida.Length);

                        break;
                    case 4: // ingeniería  i   a
                        Console.WriteLine("el primero caracter es: " + carrera[0]);
                        Console.WriteLine("el ultimo caracter es: " + carrera[carrera.Length-1]);

                        break;
                    case 7: Console.WriteLine("Saliendo...");

                        break;
                    default : Console.WriteLine("opción no valida");
                        break;

                }

            }//7 distinto a 7 (true)
            while (opcion !=7); // > < >= <= ==     !=(distinto a)
        }
    }
}
