using System;
using Name.Models;

class Program
{
    static void Main()
    {
        bool nameCorreto = false;

        while (!nameCorreto)
        {
            Console.WriteLine("Digite seu nome:");
            string nameDigitado = Console.ReadLine();


            if (nameDigitado == "Marcelo")
            {
                nameCorreto = true;
                Console.WriteLine("Seja bem vindo de volta!");
            }

            else
            {
                Console.WriteLine("Nome incorreto! Digite novamente.");
            }

            Console.ReadKey();
        }
    }
}