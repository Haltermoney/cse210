// Improvements: Added logic so the Questions on the Reflecting Activity to not repeat. Changed the Breathing Activity to Box Breathing.
using System;


class Program
{
    static void Main(string[] args)
    {
        int menu = 0;

        while (menu != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. start listing activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu: ");
            menu = int.Parse(Console.ReadLine());

            if (menu == 1)
            {
                Console.Clear();
                BreathingActivity userActivity = new BreathingActivity();
                userActivity.DisplayStartingMessage();
                userActivity.Run();
            }

            else if (menu == 2)
            {
                Console.Clear();
                ReflectingActivity userActivity = new ReflectingActivity();
                userActivity.DisplayStartingMessage();
                userActivity.Run();
            }

            else if (menu == 3)
            {
                Console.Clear();
                ListingActivity userActivity = new ListingActivity();
                userActivity.DisplayStartingMessage();
                userActivity.Run();
            }
        }
    }
}