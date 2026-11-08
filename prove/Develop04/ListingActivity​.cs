class ListingActivity : BaseActivity
{
    private List<FlaggedString> _prompts;
    
    public ListingActivity(string name, string description)
    : base (name, description)
    {
        SetPrompts();
    }

    public override int RunActivity()
    {
        StartActivity();
        StartTime();

        Console.Clear();
        Console.WriteLine("List as many responses you can to the following prompt:");
        string prompt = GetPromptString(_prompts);
        Console.WriteLine($" --- {prompt} ---\n");
        RunCountDownMessage("You may begin in:", 5);

        List<string> userItems = new List<string>();
        while (!HasTimerExpired())
        {
            Console.Write("> ");
            if (Console.KeyAvailable)
            {
                string item = Console.ReadLine();
                if (!string.IsNullOrEmpty(item))
                {
                    userItems.Add(item);
                }
            }
            else
            {
                // Small sleep to prevent tight CPU loop if no input is ready
                Thread.Sleep(100);
            }
        }

        Console.WriteLine($"\nYou listed {userItems.Count} items!");
        DisplayEnding();
        return _duration;
    }

    private void SetPrompts()
    {
        _prompts = new List<FlaggedString>
        {
            new FlaggedString("Who are people that you appreciate?", false),
            new FlaggedString("What are personal strengths of yours?", false),
            new FlaggedString("Who are people that you have helped this week?", false),
            new FlaggedString("When have you felt the Holy Ghost this month?", false),
            new FlaggedString("Who are some of your personal heroes?", false)
        };
    }
}