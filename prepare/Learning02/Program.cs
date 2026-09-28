using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Restocker";
        job1._company = "Walmart";
        job1._startYear = 2022;
        job1._endYear = 2023;
        Job job2 = new Job();
        job2._jobTitle = "Cook";
        job2._company = "Panda Express";
        job2._startYear = 2025;
        job2._endYear = 2026;

        Resume Resume1 = new Resume();
        Resume1._name = "Jacob Hughes";
        Resume1._jobs.Add(job1);
        Resume1._jobs.Add(job2);
        Resume1.Display();
    }
}