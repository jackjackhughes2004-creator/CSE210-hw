using System;

class Program
{
    static void Main(string[] args)
    {


        DateTime endTime = DateTime.Now.AddSeconds(15);

        while (DateTime.Now < endTime)
        {
            activity.RunCountDownMessage("Breath In", 5);
            activity.RunCountDownMessage("Breath out", 10);
        }
    }
}