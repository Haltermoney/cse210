public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(_prompts.Count);
        return _prompts[randomNumber];
    }

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _time = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Get ready...\n");
        ShowSpinner(4);
        Console.WriteLine("\nList as many responses as you can to the following prompt:\n");
        Console.WriteLine($"---   {GetRandomPrompt()}   ---");
        Console.WriteLine("\n You may begin in:\n");
        ShowCountDown(10);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);

        while (DateTime.Now < endTime)
        {
            Console.Write(">>>");
            Console.ReadLine();
            _count++;
        }

        Console.WriteLine($"\nYou listed {_count} items!");

        DisplayEndingMessage();
    }
}