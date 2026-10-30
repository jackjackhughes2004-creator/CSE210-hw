class Program
{
    
    static void Main()
    {
        Person myPerson = new Person("Joe", "Mother", 56, 10000);
        Console.WriteLine(myPerson.GetPersonInfo());

        Police myPolice = new Police("George", "Floyd", 34, 186, "Bazooka");
        Console.WriteLine(myPolice.GetPoliceInfo());

        Doctor myDoctor = new Doctor("Lil'", "Big Money", 5, 50, "Drugs");
        Console.WriteLine(myDoctor.GetDoctorInfo());

        List<Person> myPeople = new List<Person>();

        myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPolice);

        foreach(Person person in myPeople)
        {
            Console.WriteLine(person.GetPersonInfo());
        }
    }
}