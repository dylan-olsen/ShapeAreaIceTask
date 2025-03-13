namespace ShapeAreaCalculator;

public class Circle : Shape , CalculateArea
{
    public double PI = 3.14;
    public double radius;
    
    public Circle(string name , double radius) : base(name)
    {
        this.radius = radius;
    }

    public double CalculateArea()
    {
        //throw new NotImplementedException();
        return PI * radius * radius;
    }

    public override void display()
    {
        base.display();
        Console.WriteLine("Area of Circle" + CalculateArea());
    }
}