using System;
using System.Text.RegularExpressions;

namespace HACKATHON2022_POPGIL
{
    internal class Program
    {
        static void Main(string[] args)
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
                Number = new Regex("^[0-1]+$");
            }
            else if (Validation2 == 10)
            {
                Number = new Regex("^[0-9]+$");
            }
            else 
            {
                Number = new Regex("^[0-9a-fA-F]+$");
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
                Result = (Decimal%2) + Result;
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
