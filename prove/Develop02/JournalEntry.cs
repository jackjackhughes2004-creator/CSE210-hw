using System.Runtime.CompilerServices;

class JournalEntry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void DisplayJournalEntry()
    {
        Console.Write($"\n{_date}: ");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine($"Response: {_response}");
    }

    public void CreateJournalEntry(string date, string prompt, string response)
    {
        Console.Write($"{date}: ");
        Console.WriteLine($"{prompt}");
        Console.WriteLine($"{response}");
    }

public void CreateJournalEntry()
{
    string [] prompts =
    {
        "How was your day?",
        "Talk about someone you met.",
        "What are 5 things you are grateful for today?",
        "What is the most interesting thing you saw today?",
        "How did the important things in your life make your day better?",
        "Where did you go today?",
        "Say something you wanted to do today but didn't.",
        "What are your hopes and dreams for the future?"
    };
    
    DateTime currentDate = DateTime.Now;
    _date = currentDate.ToShortDateString();
    
    Random random = new Random();
    int index = random.Next(prompts.Length);
    _prompt = prompts[index];

    Console.Write($"{_date}: ");
    Console.WriteLine($"{_prompt}");
    Console.Write("Response > ");
    _response = Console.ReadLine();
}

    public string CreateFileSystemString()
    {
        string outputString = $"{_date}#{_prompt}#{_response}";
        return outputString;
    }

}