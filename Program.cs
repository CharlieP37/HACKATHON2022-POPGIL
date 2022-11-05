using System;
using System.Text.RegularExpressions;

namespace HACKATHON2022_POPGIL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problema No. 2 - Contador de vocales en una cadena");
            Console.WriteLine("\n");
            Console.WriteLine("Bienvenido, introduzca una cadena de texto y oprima enter para confirmar.");
            Console.WriteLine("\n");

            Console.Write("Entrada:");

            var Input = Console.ReadLine();

            int TotalVocals = VocalCounter(Input);

            Console.WriteLine("\n");
            Console.WriteLine("El total de vocales en el texto ingresado es de: " + TotalVocals);
        }

        private static int VocalCounter(string Text) 
        {
            int Counter = 0;
            char[] Vocals = {'A', 'E', 'I', 'O', 'U'};

            string Input = Text.ToUpper();

            for (int i = 0; i < Text.Length; i++)
            {
                for (int j = 0; j < Vocals.Length; j++)
                {
                    if (Input[i] == Vocals[j])
                    {
                        Counter++;
                        j = Vocals.Length;
                    }
                }
            }

            return Counter;
        }
    }
}
