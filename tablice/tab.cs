using numbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablice
{
    internal class tab
    {
        public static void TabNN01()
        {
            int a = 0;
            Console.Write("podaj ilość wierszy/kolumn: ");
            int n = GetFromUser.NumberMoreThen(0);
            int[,] myTab = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a == 0)
                    {
                        myTab[i, j] = a;
                        a = 1;
                    }
                    else
                    {
                        myTab[i, j] = a;
                        a = 0;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(myTab[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        public static void tab2()
        {

            Console.WriteLine("2. Program obliczający średnie arytmetyczne poszczególnych wierszy i kolumn tablicy 2-wymiarowej cyfr losowych o ‘k’ kolumnach i ‘w’ wierszach.");

            Console.Write("podaj ilość kolumn: ");
            int k = GetFromUser.NumberMoreThen(0);
            Console.WriteLine("Podaj ilość wierszy: ");
            int w = GetFromUser.NumberMoreThen(0);

            int[,] myTab = new int[w, k];

            Console.WriteLine("Uzupełnianie losowymi liczbami od -100 do 100");
            Console.WriteLine("Macierz wygląda tak: ");

            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    myTab[i, j] = GetFromUser.RandomNumber(-100, 100);
                    Console.Write(myTab[i, j] + " ");
                }
                Console.WriteLine();
            }

            int sum = 0;
            Console.WriteLine("średnie w posczególnych wierszach wynoszą: ");
            for (int i = 0; i < w; i++)
            {
                sum = 0;
                for (int j = 0; j < k; j++)
                {
                    sum += myTab[i, j];
                }
                Console.WriteLine("Średnia liczb w wierszu " + (i + 1) + " wynosi: " + (double)sum / k);
            }

            Console.WriteLine("średnie w posczególnych kolumnach wynoszą: ");
            for (int i = 0; i < k; i++)
            {
                sum = 0;
                for (int j = 0; j < w; j++)
                {
                    sum += myTab[j, i];
                }
                Console.WriteLine("Średnia liczb w kolumnie " + (i + 1) + " wynosi: " + (double)sum / w);
            }
        }

        public static void tab3()
        {
            Console.Write("podaj ilość kolumn i zarazem wierszy (tablica kwadratowa): ");
            int k = GetFromUser.NumberMoreThen(0);

            // tworzę i wypisuję tablicę bazową
            int[,] myTab = new int[k, k];

            Console.WriteLine("Tablica przed transpozycją:");
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    myTab[i, j] = GetFromUser.RandomNumber(-100, 100);
                    Console.Write(myTab[i, j] + " ");
                }
                Console.WriteLine();
            }

            // tworzę tablicę po transpozycji
            int[,] poTranspozycji = new int[k, k];

            Console.WriteLine("Tablica po transpozycji:");
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    int number = myTab[i, j];
                    poTranspozycji[j, i] = number;
                }
            }

            // wypisuję tablicę po transpozycji
            for (int i = 0; i < k; i++)
            {
                for(int j = 0;j < k; j++)
                {
                    Console.Write(poTranspozycji[i,j] + " ");
                }
                Console.WriteLine(" ");
            }
        }


        public static int[,] createTab(int w, int k)
        {
            int[,] myTab = new int[w, k];
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    myTab[i, j] = GetFromUser.RandomNumber(-100, 100);
                }
            }
            return myTab;
        }




    }
}
