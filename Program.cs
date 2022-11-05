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
                Problem4();
            }
            else
            {
                Console.WriteLine("Ese problema no existe");
                Console.WriteLine("Precione enter para continuar");
                Console.ReadLine();
                Main();
            }

            ExitCycleMian();
        }


        static void ExitCycleMian()
        {
            Console.WriteLine("Si desea obtener el factorial de otro número, escribir “si” si desea cerrar el programa escribir “no”.");
            string CycleString = Console.ReadLine();

            if (CycleString == "si")
            {
                ExitCycleMian();
            }
            else if (CycleString == "no")
            {
                Environment.Exit(0);
            }
            else
            {
                ExitCycleMian();
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
                ExitCycleProblem3();
            }
        }









        static void Problem4()
        {

            Console.Clear();
            Console.WriteLine("                          Repartidor de porciones");
            Console.WriteLine("");
            Console.WriteLine("Ingresar la cantidad de amigos:");

            string EntryFrendsUser = Console.ReadLine();

            Regex ValidationFirendsEntry = new Regex("^([0-9])*$");

            if (ValidationFirendsEntry.IsMatch(EntryFrendsUser))
            {
                try
                {
                    Convert.ToInt32(EntryFrendsUser);
                }
                catch (Exception)
                {
                    Console.WriteLine("El numero ingresado sobrepasa el numero permitido");
                    Console.WriteLine("");
                    Console.WriteLine("Precione enter para continuar");
                    Console.ReadLine();
                    Problem4();
                }

                string EntryPortionsUser = NumberPortions();

                int Result = NumberOfCakes(Convert.ToInt32(EntryFrendsUser), Convert.ToInt32(EntryPortionsUser), 4);
                Console.WriteLine("");
                Console.WriteLine("Si se tienen " + EntryFrendsUser + " amigos y cada uno de ellos se comeran " + EntryPortionsUser + " porciones de pastel, se necesitaran  " + Convert.ToString(Result) + " pasteles");
                ExitCycleProblem4();
            }
            else
            {
                Console.WriteLine("Debe de ingresar correctamente el numero de amigos");
                Console.WriteLine("");
                Console.WriteLine("Precione enter para continuar");
                Console.ReadLine();
                Problem4();
            }




        }


        static string NumberPortions()
        {
            string EntryPortionsUser = "";
            bool Cycle = false;
            while (Cycle == false)
            {
                Console.Clear();
                Console.WriteLine("Ingresar la cantidad de porciones:");
                EntryPortionsUser = Console.ReadLine();


                Regex ValidationPortionsEntry = new Regex("^([0-9])*$");
                if (ValidationPortionsEntry.IsMatch(EntryPortionsUser))
                {
                    try
                    {
                        Convert.ToInt32(EntryPortionsUser);
                        Cycle = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("El numero ingresado sobrepasa el numero permitido");
                        Console.WriteLine("");
                        Console.WriteLine("Precione enter para continuar");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Debe de ingresar correctamente el numero de porciones");
                    Console.WriteLine("");
                    Console.WriteLine("Precione enter para continuar");
                    Console.ReadLine();
                }
            }



            return EntryPortionsUser;
        }


        static int NumberOfCakes(int NumFirends, int NumPortions, int NumPortionCakes)
        {
            int FriendxPortoins = NumFirends * NumPortions;

            decimal Divition = Convert.ToDecimal(FriendxPortoins) / Convert.ToDecimal(NumPortionCakes);

            int Res = (int)Math.Ceiling(Divition);

            return Res;
        }


        static void ExitCycleProblem4()
        {
            Console.WriteLine("");
            Console.WriteLine("Si desea obtener el factorial de otro número, escribir “si” si desea cerrar el programa escribir “no”.");
            string CycleString = Console.ReadLine();

            if (CycleString == "si")
            {
                Problem4();
            }
            else if (CycleString == "no")
            {
                Environment.Exit(0);
            }
            else
            {
                ExitCycleProblem4();
            }
        }






    }
}
