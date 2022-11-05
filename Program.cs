using System;

namespace HACKATHON2022_POPGIL
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Bienbenido, ingrese unicamente el numero del problema que desea ver.");
            Console.WriteLine("Ejemplo: si quires ver el problema 2, ingresar un 2");
            string NumProblem = Console.ReadLine();

            if (NumProblem == "1")
            {

            }
            else if(NumProblem == "2")
            {

            }
            else if (NumProblem == "3")
            {

            }
            else if (NumProblem == "4")
            {

            }
            else
            {
                Console.WriteLine("Ese problema no existe");
                Console.WriteLine("Precione enter para continuar");
                Console.ReadLine();
                Main();
            }
        }
    }
}
