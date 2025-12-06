public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _time = 0;

    public Activity()
    {
        _name = "Unknown";
        _description = "Unknown";
        _time = 0;
    }

    public Activity(string name, string description, int time)
    {
        _name = name;
        _description = description;
        _time = time;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");
        Console.WriteLine();
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_time} seconds of the {_name}.");
        ShowSpinner(7);
    }

    public void ShowSpinner(int seconds)
    {
        int i = 0;
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(750);
            Console.Write("\b \b");

            i++;

            if (i >= animation.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowDots(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            if (i >= 100)
            {
                Console.Write("\b\b\b   \b\b\b");
            }
            else if (i >= 10)
            {
                Console.Write("\b\b  \b\b");
            }
            else
            {
                Console.Write("\b \b");
            }
        }
    }
}