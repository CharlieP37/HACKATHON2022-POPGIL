using System;
using System.Text.RegularExpressions;

namespace HACKATHON2022_POPGIL
{
    internal class Program
    {
        static void Main()
        {
            
            Console.Clear();
            Console.WriteLine("                Repartidor de porciones");
            Console.WriteLine("Ingresar la cantidad de amigos:");

            string EntryFrendsUser =Console.ReadLine();

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
                    Console.WriteLine("Precione enter para continuar");
                    Console.ReadLine();
                    Main();
                }

                string EntryPortionsUser = NumberPortions();

                int Result = NumberOfCakes(Convert.ToInt32(EntryFrendsUser), Convert.ToInt32(EntryPortionsUser), 4);

                Console.WriteLine("Si se tienen " + EntryFrendsUser + " amigos y cada uno de ellos se comeran " + EntryPortionsUser + " porciones de pastel, se necesitaran  " + Convert.ToString(Result) + " pasteles");
                Console.WriteLine("Si desea calcular la cantidad de pasteles nuevamente escriba ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Debe de ingresar correctamente el numero de amigos");
                Console.WriteLine("Precione enter para continuar");
                Console.ReadLine();
                Main();
            }




        }

        static string NumberPortions() 
        {
            Console.Clear();
            Console.WriteLine("Ingresar la cantidad de porciones:");
            string EntryPortionsUser = Console.ReadLine();


            Regex ValidationPortionsEntry = new Regex("^([0-9])*$");
            if (ValidationPortionsEntry.IsMatch(EntryPortionsUser))
            {
                try
                {
                    Convert.ToInt32(EntryPortionsUser);
                }
                catch (Exception)
                {
                    Console.WriteLine("El numero ingresado sobrepasa el numero permitido");
                    Console.WriteLine("Precione enter para continuar");
                    Console.ReadLine();
                    NumberPortions();

                }
            }
            else
            {
                Console.WriteLine("Debe de ingresar correctamente el numero de porciones");
                Console.WriteLine("Precione enter para continuar");
                Console.ReadLine();
                NumberPortions();
            }


            return EntryPortionsUser;
        }


        static int NumberOfCakes(int NumFirends, int NumPortions, int NumPortionCakes) 
        {
            int FriendxPortoins = NumFirends * NumPortions;

            float Divition = FriendxPortoins / NumPortionCakes;

            int Res = (int)Math.Ceiling(Divition);

            return Res;
        }

    }
}
