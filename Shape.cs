/*
 * CSC180 Week12 Assignment #1
 * key concepts: abstract class/method; inheritance; constructor; array of objects
 * Shape class: Shape.cs
 */

using System;

public abstract class Shape
{
    public abstract double Area();
    public static double GetArea(Shape shape)
    {
        return shape.Area();
    }
}

public class Square : Shape
{
    private double size;
    public Square(double length)
    {
        this.size = length;
    }
    public override double Area()
    {
        return Math.Pow(size, 2);
    }
}

public class Circle : Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double Area()
    {
        return Math.Round(Math.PI * Math.Pow(radius, 2), 2);
    }
}
// Add Rectangle and Triangle classes that inherit Shape
public class Rectangle : Shape
{
    private double width;
    private double length;
    public Rectangle(double width, double length)
    {
        this.width = width;
        this.length = length;
    }
    public override double Area()
    {
        return width * length;
    }
}
public class Triangle : Shape
{
    private double baseLength;
    private double height;
    public Triangle(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }
    public override double Area()
    {
        return 0.5 * baseLength * height;
    }
}
