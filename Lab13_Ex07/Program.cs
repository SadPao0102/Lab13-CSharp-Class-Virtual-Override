using System;

public abstract class Shape
{
    public abstract double Area(); // เมทอดสำหรับคำนวณพื้นที่
    public abstract void Draw(); // เมทอดสำหรับวาดรูปทรง
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius; // กำหนดค่า radius
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius; // คำนวณพื้นที่วงกลม
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a circle with radius {Radius}"); // วาดวงกลม
    }
}

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width; // กำหนดค่า width
        Height = height; // กำหนดค่า height
    }

    public override double Area()
    {
        return Width * Height; // คำนวณพื้นที่สี่เหลี่ยมผืนผ้า
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a rectangle with width {Width} and height {Height}"); // วาดสี่เหลี่ยมผืนผ้า
    }
}

public class ShapeProcessor
{
    public void DisplayShapeInfo(Shape shape) // เมทอดสำหรับแสดงข้อมูลรูปทรง
    {
        Console.WriteLine($"Area of {shape.GetType().Name}: {shape.Area()}"); // แสดงพื้นที่
        shape.Draw(); // เรียกเมทอดวาดรูปทรง
    }
}

class Program
{
    static void Main()
    {
        ShapeProcessor processor = new ShapeProcessor(); // สร้างอ็อบเจ็กต์ ShapeProcessor

        Circle circle = new Circle(5); // สร้างอ็อบเจ็กต์ Circle
        processor.DisplayShapeInfo(circle); // แสดงข้อมูลวงกลม

        Rectangle rectangle = new Rectangle(4, 6); // สร้างอ็อบเจ็กต์ Rectangle
        processor.DisplayShapeInfo(rectangle); // แสดงข้อมูลสี่เหลี่ยมผืนผ้า
    }
}
