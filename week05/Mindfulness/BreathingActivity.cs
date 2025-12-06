public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity uses a method called \"Box Breathing\"\nBox Breathing helps to calm the nervous system and counteract the stress response\n\nTo perform Box breathing do the following\n   1. Inhale for a count of four\n   2. Hold your breath for a count of four\n   3. Exhale for a count of four\n   4. Hold your breath for a count of four\n   5. Repeat these steps until your time is up";
    }
    public void Run()
    {
        int i = 0;
        List<string> breathing = new List<string>
        {
           "Inhale",
            "Hold",
            "Exhale",
            "Hold"
        };

        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _time = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.Write("Get ready");
        ShowDots(4);
        Console.WriteLine();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);

        while (DateTime.Now < endTime)
        {
            string s = breathing[i];
            Console.Write(s);
            Thread.Sleep(1000);
            ShowDots(4);
            Console.WriteLine();
            Console.WriteLine();

            i++;

            if (i >= breathing.Count)
            {
                i = 0;
            }
        }
        Console.WriteLine();
        DisplayEndingMessage();
    }
}