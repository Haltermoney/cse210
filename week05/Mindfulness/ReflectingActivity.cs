public class ReflectingActivity : Activity
{
    List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    List<String> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(_prompts.Count);
        return _prompts[randomNumber];
    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomNumber = random.Next(_questions.Count);
        string question = _questions[randomNumber];
        _questions.RemoveAt(randomNumber);
        return question;
    }

    public void Run()
    {
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _time = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Get ready");
        ShowDots(4);
        Console.WriteLine("\nConsider the following prompt:\n");
        Console.WriteLine($"---   {GetRandomPrompt()}   ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.\n");
        Console.ReadLine();
        Console.WriteLine("Now Ponder on each of the following questions as they related to this experience.");
        Console.Write("You may being in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);

        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(10);
            Console.WriteLine();
        }

        DisplayEndingMessage();

    }
}