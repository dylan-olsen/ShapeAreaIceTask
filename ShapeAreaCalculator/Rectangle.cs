namespace ShapeAreaCalculator;

public class Rectangle : Shape, CalculateArea
{
    public double width { get; set; }
    public double height { get; set; }


    public Rectangle(string name, double width , double height) : base(name)
    {
        this.width = width;
        this.height = height;
    }

    public double CalculateArea()
    {
       // throw new NotImplementedException();
       return width * height;
    }
}