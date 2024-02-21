using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numbers
{
    internal class GetFromUser
    {

        public static int Number()
        {
            int liczba;
            do
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out liczba))
                {
                    return liczba;

                }
                else
                {
                    Console.WriteLine("Błędna wartość. Podaj liczbe całkowita");
                }
            } while (true);
        }

        public static int NumberMoreThen(int a)
        {
            int liczba;
            do
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out liczba))
                {
                    if (liczba <= a)
                    {
                        Console.WriteLine("Za mała wartość. Podaj jeszcze raz");
                    }
                    else
                    {
                        return liczba;
                    }
                }
                else
                {
                    Console.WriteLine("Błędna wartość. Podaj liczbe całkowita");
                }
            } while (true);
        }

        public static int NumberBetween(int a, int b)
        {
            Console.Write("podaj liczbe całkowitą z przediału od " + a + " do " + b + ": ");
            int liczba;
            do
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out liczba))
                {
                    if (liczba >= a && liczba <= b)
                    {
                        return liczba;
                    }
                    else
                    {
                        Console.WriteLine("Błędna wartość. podaj liczbe całkowitą z przediału od " + a + " do " + b);
                    }
                }
                else
                {
                    Console.WriteLine("Błędna wartość. podaj liczbe całkowitą z przediału od " + a + " do " + b);
                }
            } while (true);
        }

        public static int RandomNumber(int a, int b)
        {
            Random random = new Random();
            int randomNumber = random.Next(a, b);
            return randomNumber;
        }


    }
}
