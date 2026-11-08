class FlaggedString
{
    private string _prompt;
    private bool _hasBeenUsed;

    public FlaggedString(string prompt, bool hidden)
    {
        _prompt = prompt;
        _hasBeenUsed = hidden;
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public void SetHasBeenUsed(bool value)
    {
        _hasBeenUsed = value;
    }

    public bool GetHasBeenUsed()
    {
        return _hasBeenUsed;
    }    
}