class Brokie : Person
{
    private bool _homeOwner;

    public Brokie (string firstName, string lastName, int age, double weight, bool homeOwner)
    : base (firstName, lastName, age, weight)
    {
        _homeOwner = homeOwner;
    }

    public override string GetPersonInfo()
    {
        return base.GetPersonInfo();
    }

    public override double GetSalary()
    {
        return 0.0;
    }
}