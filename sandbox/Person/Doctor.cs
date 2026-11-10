class Doctor : Person
{
    private string _tools;
    
    public Doctor (string firstName, string lastName, int age, double weight, string tools)
    : base (firstName, lastName, age, weight)
    {
        _tools = tools;
    } 

    public override string GetPersonInfo()
    {
        return $"Doctor: {base.GetPersonInfo()}Tools: {_tools}";
    }

    public override double GetSalary()
    {
        return 350000.00;
    }
}