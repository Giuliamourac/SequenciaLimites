using System;

namespace Programa
{ 

    class Limite
    {
    
        static void Main (string[] args)
        {

            int numero1 = 0;

            int numero2 = 0;

            Console.WriteLine("Digite um numero");

            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro numero");

            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero2 <= numero1)
            {

                Console.WriteLine("ERRO! 2º numero precisa ser maior que o 1º.");

                Console.WriteLine("Digite um numero");

                numero1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite outro numero");

                numero2 = Convert.ToInt32(Console.ReadLine());

            }

            else
            {


            }

            for (int i = numero1; i <= numero2; i++)
            {

                Console.WriteLine($"{i}");

            }

        }
    
    }

}