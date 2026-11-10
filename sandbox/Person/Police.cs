class Police : Person
{
    private string _weapons;
    
    public Police (string firstName, string lastName, int age, double weight, string weapons)
    : base (firstName, lastName, age, weight)
    {
        _weapons = weapons;
    } 

    public override string GetPersonInfo()
    {
        return $"Police Officer: {base.GetPersonInfo()}Weapons: {_weapons}";
    }

    public override double GetSalary()
    {
        return 150.00;
    }
}