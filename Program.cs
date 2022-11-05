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
                Problem1();
            }
            else if(NumProblem == "2")
            {
                Problem2();
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



        static void Problem2()
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
            char[] Vocals = { 'A', 'E', 'I', 'O', 'U' };

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



        /// <summary>

        static void Problem1()
        {
            Console.WriteLine("Problema No. 1 - Calculadora de sumas y restas en binario, decimal y hexadecimal");
            Console.WriteLine("\n");
            Console.WriteLine("Bienvenido, seleccione el tipo de operación que desea hacer, luego la base de los números y los respectivos números.");
            Console.WriteLine("\n");


            int Validation1 = -1;
            while (Validation1 == -1)
            {
                Console.WriteLine("Seleccione el tipo de operación a realizar: ");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");

                Console.WriteLine("\n");
                Console.Write("Opción: ");
                var Operation = Console.ReadLine();
                Validation1 = VerifyOperation(Operation);
            }

            Console.WriteLine("\n");

            int Validation2 = -1;
            while (Validation2 == -1)
            {
                Console.WriteLine("Seleccione la base del números: ");
                Console.WriteLine("1. Decimal");
                Console.WriteLine("2. Binario");
                Console.WriteLine("3. Hexadecimal");

                Console.WriteLine("\n");
                Console.Write("Opción: ");
                var Base = Console.ReadLine();
                Validation2 = VerifyBase(Base);
            }

            Console.WriteLine("\n");

            Regex Number;
            if (Validation2 == 2)
            {
                Number = new Regex("^[0-1]+${1,20}");
            }
            else if (Validation2 == 10)
            {
                Number = new Regex("^[0-9]+${1,20}");
            }
            else
            {
                Number = new Regex("^[0-9a-fA-F]+${1,10}");
            }

            bool NumberVerification = false;
            string Number1 = "";
            string Number2 = "";

            while (!NumberVerification)
            {
                Console.Write("Ingrese el primer número: ");

                Console.WriteLine("\n");
                Console.Write("Número: ");
                Number1 = Console.ReadLine();
                NumberVerification = Number.IsMatch(Number1);
                if (NumberVerification == false)
                {
                    Console.WriteLine("Error, entrada incorrecta. Vuela a intentarlo.\n");
                }
            }


            NumberVerification = false;

            while (!NumberVerification)
            {
                Console.WriteLine("\n");
                Console.Write("Ingrese el segundo número: ");

                Console.WriteLine("\n");
                Console.Write("Número: ");
                Number2 = Console.ReadLine();
                NumberVerification = Number.IsMatch(Number2);
                if (NumberVerification == false)
                {
                    Console.WriteLine("Error, entrada incorrecta. Vuela a intentarlo.\n");
                }
            }

            int Result = Operate(Validation1, Validation2, Number1, Number2);

            Console.WriteLine("\n");
            Console.WriteLine("El resultado de la operación es: \n");
            Console.WriteLine("Binario: " + DecimalToBinary(Result));
            Console.WriteLine("Decimal: " + Result);
            Console.WriteLine("Hexadecimal: " + DecimalToHexadecimal(Result));

        }

        private static int VerifyOperation(string Input)
        {
            if (Input.ToUpper() == "SUMA" || Input.ToUpper() == "1")
            {
                return (0);
            }
            else if (Input.ToUpper() == "RESTA" || Input.ToUpper() == "2")
            {
                return (1);
            }
            else
            {
                return (-1);
            }
        }

        private static int VerifyBase(string Input)
        {
            if (Input.ToUpper() == "DECIMAL" || Input.ToUpper() == "1")
            {
                return (10);
            }
            else if (Input.ToUpper() == "BINARIO" || Input.ToUpper() == "2")
            {
                return (2);
            }
            else if (Input.ToUpper() == "HEXADECIMAL" || Input.ToUpper() == "3")
            {
                return (16);
            }
            else
            {
                return (-1);
            }
        }

        private static int Operate(int Operation, int Base, string Number1, string Number2)
        {
            int Result = 0;

            if (Operation == 0)
            {
                Result = ToDecimal(Number1, Base) + ToDecimal(Number2, Base);
            }
            else
            {
                Result = ToDecimal(Number1, Base) - ToDecimal(Number2, Base);
            }

            return Result;
        }

        private static Int32 ToDecimal(string Number, int Base)
        {
            if (Base == 2)
            {
                return (BinaryToDecimal(Number));
            }
            else if (Base == 10)
            {
                return Convert.ToInt32(Number);
            }
            else
            {
                return (Convert.ToInt32(Number, 16));
            }
        }

        private static int BinaryToDecimal(string Num)
        {
            int Result = 0;

            for (int i = 0; i < Num.Length; i++)
            {
                Result = Result * 2 + Convert.ToInt32(Convert.ToString(Num[i]));
            }

            return Result;
        }

        private static string DecimalToBinary(int Number)
        {
            string Result = "";
            int Decimal = Number;

            while (Decimal > 1)
            {
                Result = (Decimal % 2) + Result;
                Decimal = Decimal / 2;
            }

            return Result;
        }

        private static string DecimalToHexadecimal(int Number)
        {
            string Result = "";

            int Decimal = Number;

            while (Decimal > 1)
            {
                int Remainder = (Decimal % 16);
                if (Remainder > 9)
                {
                    switch (Remainder)
                    {
                        case 11:
                            Result = "B" + Result;
                            break;
                        case 12:
                            Result = "C" + Result;
                            break;
                        case 13:
                            Result = "D" + Result;
                            break;
                        case 14:
                            Result = "E" + Result;
                            break;
                        case 15:
                            Result = "F" + Result;
                            break;
                        default:
                            Result = "A" + Result;
                            break;
                    }
                }
                else
                {
                    Result = Remainder + Result;
                }
                Decimal = Decimal / 16;
            }

            return Result;
        }
    }



}

