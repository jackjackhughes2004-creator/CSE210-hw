using System.Runtime.InteropServices;

class BaseActivity
{
    private string _name;
    private string _description;
    protected int _duration;
    private DateTime _endTime;
    
    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");
        ObtainDuration();
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinnerMessage("", 3);
        Console.Clear();
    }

    public void DisplayEnding()
    {
        Console.Clear();
        Console.WriteLine("Good Job!");
        DisplaySpinnerMessage("", 3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        DisplaySpinnerMessage("", 3);
    }

    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for (int i = seconds; i >= 0; i--)
        {
            Console.Write($"\r{message} {i} ");
            Thread.Sleep(1000);
        }
        Console.CursorVisible = true;
        Console.WriteLine();
    }
    
    public void DisplaySpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        Console.Write($"{message} ");
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write("--");
            Thread.Sleep(200);
            Console.Write("\b\b");
            Console.Write("\\ ");
            Thread.Sleep(200);
            Console.Write("\b\b");
            Console.Write("| ");
            Thread.Sleep(200);
            Console.Write("\b\b");
            Console.Write("/ ");
            Thread.Sleep(200);
            Console.Write("\b\b");
        }
        Console.CursorVisible = true;
    }

    public void StartTime()
    {
        _endTime = DateTime.Now.AddSeconds(_duration);
    }

    public bool HasTimerExpired()
    {
        return DateTime.Now >= _endTime;
    }

    private void ObtainDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int duration))
        {
            _duration = duration;
        }
        else
        {
            _duration = 30;
        }
    }

    public string GetPromptString(List<FlaggedString> list)
    {
        bool allUsed = true;
        foreach (var item in list)
        {
            if (!item.GetHasBeenUsed())
            {
                allUsed = false;
                break;
            }
        }
        if (allUsed)
        {
            foreach (var item in list)
            {
                item.SetHasBeenUsed(false);
            }
        }

        Random rand = new Random();
        while (true)
        {
            int index = rand.Next(list.Count);
            if (!list[index].GetHasBeenUsed())
            {
                list[index].SetHasBeenUsed(true);
                return list[index].GetPrompt();
            }
        }
    }

    public virtual int RunActivity()
    {
        return _duration;
    }
}