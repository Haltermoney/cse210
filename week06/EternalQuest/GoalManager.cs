using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _menu = 0;
    private int _subMenu = 0;
    private string name = "";
    private string description = "";
    private string points = "";
    private int target;
    private int bonus;
    public GoalManager()
    {

    }

    public void Start()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("   1. Create New Goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Goals");
        Console.WriteLine("   5. Record Event");
        Console.WriteLine("   6. Quit");
        Console.Write("Select a choice from the menu: ");
        _menu = int.Parse(Console.ReadLine());

        if (_menu == 1)
        {
            CreateGoal();
        }

        else if (_menu == 2)
        {
            ListGoalDetails();
        }

        else if (_menu == 3)
        {
            SaveGoals();
        }

        else if (_menu == 4)
        {
            LoadGoals();
        }

        else if (_menu == 5)
        {
            RecordEvent();
        }
    }

    public int GetMenu()
    {
        return _menu;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public void ListGoalNames()
    {

    }

    public void ListGoalDetails()
    {
        int j = 1;
            Console.WriteLine("The goals are:");
            foreach (Goal goal in _goals)
            {
                Console.Write($"{j}. ");
                Console.WriteLine(goal.GetDetailsString());
                j++;
            }
    }

    public void CreateGoal()
    {
         Console.WriteLine("The types of Goals are:");
            Console.WriteLine("   1. Simple Goal");
            Console.WriteLine("   2. Eternal Goal");
            Console.WriteLine("   3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            _subMenu = int.Parse(Console.ReadLine());


            if (_subMenu == 1)
            {
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                points = Console.ReadLine();
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
            }

            else if (_subMenu == 2)
            {
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                points = Console.ReadLine();
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
            }

            else if (_subMenu == 3)
            {
                Console.Write("What is the name of your goal? ");
                name = Console.ReadLine();
                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                points = Console.ReadLine();
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                bonus = int.Parse(Console.ReadLine());
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(checklistGoal);
            }
    }

    public void RecordEvent()
    {
        int j = 1;
            Console.WriteLine("The goals are:");
            foreach (Goal goal in _goals)
            {
                Console.Write($"{j}. ");
                Console.WriteLine(goal.GetDetailsString());
                j++;
            }
            Console.Write("Which goal did you accomplish? ");
            int input = int.Parse(Console.ReadLine());
            input--;
            _goals[input].RecordEvent();
            Console.WriteLine($"Congratulations! You have earned {_goals[input].GetPoints()} points!");
            _score += int.Parse(_goals[input].GetPoints());
            Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split("~~~");
                if (parts[0] == "SimpleGoal")
                {
                    SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], parts[3], bool.Parse(parts[4]));
                    _goals.Add(simpleGoal);
                }

                else if (parts[0] == "EternalGoal")
                {
                    EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], parts[3]);
                    _goals.Add(eternalGoal);
                }

                else if (parts[0] == "ChecklistGoal")
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));
                    _goals.Add(checklistGoal);
                }

                else
                {
                    _score = int.Parse(parts[0]);
                }
            }
    }
}