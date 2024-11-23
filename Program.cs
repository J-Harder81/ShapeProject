/*
 * CSC180 Week12 Assignment #1
 * key concepts: abstract class/method; inheritance; constructor; array of objects
 * Tester: Program.cs
 */
using System;
using System.Drawing;
public class Program
{
    public static void Main()
    {   // Creates an array called shapes and stores the new shapes and their sizes to calculate the area
        Shape[] shapes = { new Square(10), new Circle(10), new Rectangle(5, 10), new Triangle(15, 10) };
        foreach (var shape in shapes)   // Iterates over each shape in the array
        {
            Console.WriteLine($"Area of {shape}: {shape.Area()}");  // Envokes the Area method returning the overridden area calculation for each shape class
            Console.WriteLine($"Area of {shape}: {Shape.GetArea(shape)}, again"); /* Envokes the static GetArea method taking the shape as a parameter 
                                                                                   * returning the same area calculation as the Area method */
        }
    }
}