using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculadoraneitor
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Que desea realizar? \n[1]Suma \n[2]Resta \n[3]Multiplicación \n[4]División");
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    suma();
                    break;
                case 2:
                    //resta();
                    break;
                case 3:
                    //multi();
                    break;
                case 4:
                    //div();
                    break;
            }

            void suma()
            {
                Console.WriteLine("Inserte el primer digito");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserte el segundo digito");
                int n2 = int.Parse(Console.ReadLine());
                int res = n1 + n2;
                Console.WriteLine("El resultado de la suma " + n1 + " y " + n2 + " es igual a " + res);
            }
        }
    }
}