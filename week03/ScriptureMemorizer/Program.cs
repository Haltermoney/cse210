using System;

class Program
{
    static void Main(string[] args)
    {
        string userCommand = "run";
        int randomWordsToHide;

        Reference reference = new Reference();
        reference.SetReference("John", 3, 16);

        Console.Clear();

        Console.WriteLine("Welcome to your scripture memorization program!");
        Console.WriteLine("How many words would you like to hide while memorizing your scripture?");
        Console.Write(">>> ");
        string input = Console.ReadLine();
        randomWordsToHide = int.Parse(input);

        Scripture scripture = new Scripture();
        scripture.SetScripture(reference, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        while (userCommand != "quit")
        {
            Console.Clear();
            string fullScripture = scripture.GetDisplayText();

            Console.WriteLine(fullScripture);
            scripture.HideRandomWords(randomWordsToHide);

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userCommand = Console.ReadLine();

            if (scripture.IsCompletelyHidden())
            {
                userCommand = "quit";
            }

        }
    }
}