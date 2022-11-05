using System;
using System.Text.RegularExpressions;

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
                Problema3();
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






        static void Problema3()
        {
            Console.Clear();
            Console.WriteLine("                        Sumatoria factorial");
            Console.WriteLine("Ingresar un numero: ");

            string EntryUser = Console.ReadLine();

            Regex ValidationEntry = new Regex("^([0-9])*$");

            if (ValidationEntry.IsMatch(EntryUser))
            {
                UInt64 Res = FactorialCalculation(Convert.ToUInt64(EntryUser));
                Console.WriteLine("El factorial de " + EntryUser + " es: " + Convert.ToString(Res));
                ExitCycleProblem3();
            }
            else
            {
                Console.WriteLine("La entrada es incorrecta, debe de ingresar un numero.");
                Console.WriteLine("Precione enter para continuar");
                Console.ReadLine();
                Problema3();
            }
        }

        static UInt64 FactorialCalculation(UInt64 NumberEntry)
        {
            UInt64 Solution = 1;

            for (UInt64 i = 1; i < NumberEntry; i++)
            {
                Solution = Solution * i;
            }

            return Solution;
        }

        static void ExitCycleProblem3()
        {
            Console.WriteLine("Si desea obtener el factorial de otro número, escribir “si” si desea cerrar el programa escribir “no”.");
            string CycleString = Console.ReadLine();

            if (CycleString == "si")
            {
                Problema3();
            }
            else if (CycleString == "no")
            {
                Environment.Exit(0);
            }
            else
            {
                ExitCycle();
            }
        }










    }
}
