class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endTime;
    
    public BaseActivity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void StartActivity()
    {
        //TODO
    }

    public void DisplayEnding()
    {
        //TODO
    }

    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for (int i=seconds; i >= 1; i--)
        {
        Console.Clear();
        Console.Write($"{message} - {i} ");
        Thread.Sleep(1000);
        }
        Console.CursorVisible = true;
    }
    
    public void DisplaySpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        Console.Clear();
        Console.Write($"{message} ");
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write("--");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b");
        }
        Console.CursorVisible = true;
    }

    public void StartTime()
    {
        //TODO
    }

    /*public bool HasTimerExpired()
    {
        //TODO
    }
    */

    private void ObtainDuration()
    {
        
    }

    /*public string GetPromptString(List<FlaggedString>)
    {
        
    }
    */
}