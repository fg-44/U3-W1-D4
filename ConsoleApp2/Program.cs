using System;
using static System.Collections.Specialized.BitVector32;

public static class User
{

    static void Main(string[] args)
    {
        ScriviMenu();
    }

    public static void ScriviMenu()
    {
        do
        {
            Console.WriteLine("==========OPERAZIONI==========\n" +
                               "Scegli l'operazione da effettuare:\n" +
                               "1 .: Login\n" +
                               "2 .: Logout\n" +
                               "3 .: Verifica ora e data di login\n" +
                               "4 .: Lista degli accessi\n" +
                               "5 .: Esci\n");

            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1:
                    Console.WriteLine("Logging in...");
                    break;

                case 2:
                    Console.WriteLine("Logging out...");
                    break;

                case 3:
                    Console.WriteLine("Verifica ora e data di login...\n");
                    break;

                case 4:
                    Console.WriteLine("Lista degli accessi...\n");
                    break;

                case 5:
                    Console.WriteLine("Exiting application...");
                    break;

                default:
                    Console.WriteLine("Invalid selection, please try again.\n");
                    break;
            }

        } while (scelta: != 5)


        ScriviMenu();
    }
}
