using System;

class Program
{
    static void Main(string[] args)
    {
       // main -- loops through menu and calls method based on choice
       Console.WriteLine("Menu Options:" +
        "\n1. Start breathing activity" +
        "\n2. Start reflecting activity" +
        "\n3. Start listing activity" +
        "\n4. Quit" +
        "\nSelect a choice from the menu:");

        String s1 = null;

        s1 = Console.ReadLine();

        switch(s1){
            case "1":
                Console.WriteLine("You have selected breathing activity");
                break;
            case "2":
                Console.WriteLine("You have selected reflecting activity");
                break;
            case "3":
                Console.WriteLine("You have selected listing activity");
                break;
            case "4":
                Console.WriteLine("Option Quit");
                break;
            default:
                Console.WriteLine("You have selected an invalid option. Please try another option [1-4]");
                break;
        }

        Console.ReadKey();
    }
}