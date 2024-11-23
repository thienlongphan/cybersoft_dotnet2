namespace session9;

public class Rectangle
{
    public int width;
    public int length;

    public int s;
    public int p;

    public void Input()
    {
        Console.WriteLine("Enter the width: ");
        width = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the length: ");
        length = Convert.ToInt32(Console.ReadLine());
    }

    public void CalculateArea()
    {
        s = width * length;
    }

    public void CircumferenceCalculation()
    {
        p = (width + length) * 2;
    }

    public void Output()
    {
        Console.WriteLine("The area of the rectangle is: " + s);
        Console.WriteLine("The Circumference Calculation: " + p);
    }
}