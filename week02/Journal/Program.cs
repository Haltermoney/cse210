/* Dinosaur "Facts" were added as an option because my kids love dinosaurs and I thought they would like to help me with my homework*/
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        Journal myJournal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");

        //Create a while loop that will allow the program to run into the user chooses to exit
        while (choice != 6)
        {

            //Main menu
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display entries");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Dinosaur \"Facts\"");
            Console.WriteLine("6. Quit");
            Console.WriteLine();
            Console.WriteLine("What would you like to do?");
            Console.Write(">>> ");
            choice = int.Parse(Console.ReadLine());

            //Option 1: give the user a prompt to write. Concat the date and prompt to the beginning of the journal entry.
            if (choice == 1)
            {
                Console.WriteLine();

                Entry entry = new Entry();
                DateTime theCurrentTime = DateTime.Now;
                entry._date = theCurrentTime.ToShortDateString();
                //This will get a random prompt from GetRandomPrompt()
                PromptGenerator newPrompt = new PromptGenerator();
                entry._promptText = newPrompt.GetRandomPrompt();

                Console.WriteLine(entry._promptText);
                Console.Write(">>> ");
                entry._entryText = Console.ReadLine();

                Console.WriteLine();
                entry.Display();
                Console.WriteLine();

                myJournal.AddEntry(entry);
            }

            else if (choice == 2)
            {
                myJournal.DisplayAll();
            }

            else if (choice == 3)
            {
                myJournal.SaveToFile("journal.txt");
            }

            else if (choice == 4)
            {
                myJournal.LoadFromFile("journal.txt");
            }

            else if (choice == 5)
            {
                Console.WriteLine("***Dinosaur \"Facts\" were given to me by my 4 year old and 5 year old and may not be true***");
                DinosaurFacts dinoFact = new DinosaurFacts();
                string fact = dinoFact.GetDinosaurFacts();
                Console.WriteLine($"{fact}\n");
            }
        }
    }
}