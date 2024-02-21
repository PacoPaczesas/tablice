using numbers;
using tablice;


bool exit = false;

while (!exit)
{
    Console.WriteLine("Wybierz program:");
    Console.WriteLine("1. Program wypełniający tablicę 2-wymiarową rozmiaru n na n na przemian ‘0’ lub ‘1’");
    Console.WriteLine("2. Program obliczający średnie arytmetyczne poszczególnych wierszy i kolumn tablicy 2-wymiarowej cyfr losowych o ‘k’ kolumnach i ‘w’ wierszach.");
    Console.WriteLine("TODO 3. Program wyświetlający tablicę kwadratową cyfr rozmiaru ‘n’ oraz jej przekątnych.");
    Console.WriteLine("4. Program dokonujący transponowania tablicy kwadratowej");

    int option = GetFromUser.NumberBetween(0, 10);

    switch (option)
    {
        case 1:
            tab.TabNN01();
            break;
        case 2:
            tab.tab2();
            break;
        case 3:

            break;
        case 4:
            tab.tab3();
            break;
        case 5:
            exit = true;
            break;
        default:
            Console.WriteLine("Błędna wartość");
            break;
    }
    Console.WriteLine("------------------------");
}

