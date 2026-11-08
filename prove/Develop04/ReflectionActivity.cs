class ReflectionActivity : BaseActivity
{
    private List<FlaggedString> _prompts;
    private List<FlaggedString> _questions;

    public ReflectionActivity(string name, string description)
    : base (name, description)
    {
        SetPromptsAndQuestions();
    }

    public override int RunActivity()
    {
        StartActivity();
        StartTime();

        Console.Clear();
        Console.WriteLine("Consider the following prompt:\n");
        string prompt = GetPromptString(_prompts);
        Console.WriteLine($" --- {prompt} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Now think about how the next questions relate experience.");

        while (!HasTimerExpired())
        {
            string question = GetPromptString(_questions);
            Console.Write($"> {question} ");
            DisplaySpinnerMessage("", 5);
            Console.WriteLine();
        }

        DisplayEnding();
        return _duration;
    }

    private void SetPromptsAndQuestions()
    {
        _prompts = new List<FlaggedString>
        {
            new FlaggedString("Think of a time when you stood up for someone else.", false),
            new FlaggedString("Think of a time when you did something really difficult.", false),
            new FlaggedString("Think of a time when you helped someone in need.", false),
            new FlaggedString("Think of a time when you did something truly selfless.", false)
        };

        _questions = new List<FlaggedString>
        {
            new FlaggedString("Why was this experience meaningful to you?", false),
            new FlaggedString("Have you ever done anything like this before?", false),
            new FlaggedString("How did you get started?", false),
            new FlaggedString("How did you feel when it was complete?", false),
            new FlaggedString("What made this time different than other times when you were not as successful?", false),
            new FlaggedString("What is your favorite thing about this experience?", false),
            new FlaggedString("What could you learn from this experience that applies to other situations?", false),
            new FlaggedString("What did you learn about yourself through this experience?", false),
            new FlaggedString("How can you keep this experience in mind in the future?", false)
        };
    }
}