class Program
{
    static void DisplayPersonInformation(Person person)
    {
        // if (person is Doctor d)
        // {
        //     Console.WriteLine(d.GetDoctorInfo());
        // }
        // else if (person is Police p)
        // {
        //     Console.WriteLine(p.GetPoliceInfo());
        // }
        // else
        // {
            Console.WriteLine(person.GetPersonInfo());
            Console.WriteLine($"Salary: {person.GetSalary()}\n");
        // }
    }
    
    static void Main()
    {
        // Person myPerson = new Person("Joe", "Mother", 56, 10000);
        //Console.WriteLine(myPerson.GetPersonInfo());

        Police myPolice = new Police("George", "Washington", 34, 186, "Bazooka");
        //Console.WriteLine(myPolice.GetPoliceInfo());

        Doctor myDoctor = new Doctor("Lil'", "Big Money", 5, 50, "Drugs");
        //Console.WriteLine(myDoctor.GetDoctorInfo());

        Brokie myBrokie = new Brokie("Alex", "Hughes", 15, 300, false);

        List<Person> myPeople = new List<Person>();

        myPeople.Add(myBrokie);
        myPeople.Add(myDoctor);
        myPeople.Add(myPolice);

        foreach(Person person in myPeople)
        {
            DisplayPersonInformation(person);
            // Console.WriteLine(person.GetPersonInfo());
            // if (person is Doctor d)
            // {
            // }
        }
    }
}