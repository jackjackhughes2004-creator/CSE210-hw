class BreathingActivity : BaseActivity
{
    public BreathingActivity(string name, string description)
    : base (name, description)
    {    
    }

    public override int RunActivity()
    {
        StartActivity();
        StartTime();

        while (!HasTimerExpired())
        {
            RunCountDownMessage("Breathe in...", 5);
            if (HasTimerExpired()) break;
            RunCountDownMessage("Now breathe out...", 5);
        }

        DisplayEnding();
        return _duration;
    }
}