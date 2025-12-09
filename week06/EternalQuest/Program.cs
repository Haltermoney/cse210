using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager main = new GoalManager();

        while (main.GetMenu() != 6)
        {
            main.DisplayPlayerInfo();

            main.Start();
        }
    }
}