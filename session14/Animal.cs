namespace session14;

public class Animal : IEat, ISleep
{
    private string name;
    public string Name { get => name; set => name = value; }

    public Animal(string name)
    {
        Name = name;
    }

    public void Eat()
    {
        Console.WriteLine("I'm eating!");
    }

    public void Sleep()
    {
        Console.WriteLine("I'm sleeping!");
    }
}