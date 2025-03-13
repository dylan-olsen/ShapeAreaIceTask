namespace ShapeAreaCalculator;

class Program
{
    static void Main(string[] args)
    {
        // creating instance of rectangle 
        Rectangle rect = new Rectangle("Rectnalge", 10, 20);
        rect.display();
        
        // creating indtance of circle 
        Circle circle = new Circle("Circle", 5);
        circle.display();
    }
}