class Program
{
    
    static void Main()
    {
        Person myPerson = new Person("Joe", "Mother", 56, 10000);

        myPerson.DisplayPersonInfo();

        Police myPolice = new Police("Lance", "Bob", 34, 186, "Taser");

        myPolice.DisplayPersonInfo();
    }
}