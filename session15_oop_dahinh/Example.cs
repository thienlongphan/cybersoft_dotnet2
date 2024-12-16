namespace session15_oop_dahinh;

public abstract class Animal
{
    private string _name;
    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public Animal(string name)
    {
        Name = name;
    }

    public abstract void Speak();
    public abstract void DisplayInfo();
}

public class Dog : Animal
{
    private string _breed;

    public string Breed
    {
        get => _breed;
        set => _breed = value;
    }

    public Dog(string breed, string name) : base(name)
    {
        Breed = breed;
    }

    public override void Speak()
    {
        Console.WriteLine($"Gau Gau");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Breed: {Breed}");
    }
}

public class Cat : Animal
{
    private string _color;

    public string Color
    {
        get => _color;
        set => _color = value;
    }

    public Cat(string name, string color) : base(name)
    {
        Color = color;
    }

    public override void Speak()
    {
        Console.WriteLine($"Meo Meo");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Color: {Color}");
    }
    
}