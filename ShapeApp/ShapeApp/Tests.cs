using System;
using System.Collections.Generic;


namespace ShapeApp
{

    public class TestClass
    {
        public static void Main()
        {

            Console.WriteLine("Shape Application!\n");
            List<Shape> Shapes = new List<Shape>();

            // Create Shapes
            Circle circle1 = new Circle(2.0);
            Circle circle2 = new Circle(3.0);

            Triangle triangle1 = new Triangle(2, 2, 2, 1.73205); // Equilateral Triangle
            Triangle triangle2 = new Triangle(2, 2, 2, 1.65831); // Isoceles Triangle
            Triangle triangle3 = new Triangle(3, 5, 3, 1.45237); // Escalene Triangle


            Quadilateral square = new Quadilateral(2, 2); // Square
            Quadilateral rectangle = new Quadilateral(2, 2); // Rectangle

            //Add to collection
            Shapes.Add(circle1);
            Shapes.Add(circle2);
            Shapes.Add(triangle1);
            Shapes.Add(triangle2);
            Shapes.Add(triangle3);
            Shapes.Add(square);
            Shapes.Add(rectangle);

            System.Console.WriteLine("\nShapes Collection - Unsorted:\n");
            ShapeHelper.PrintShapes(Shapes);

            // Sort by Area
            Shapes.Sort();
            System.Console.WriteLine("\nSorted Shapes Collection By Area:\n");
            ShapeHelper.PrintShapes(Shapes);


            // Sort by Perimeter
            List<Shape> objListPerimeterOrder = Shapes.OrderBy(Shape => Shape.Perimeter).ToList();
            System.Console.WriteLine("\nSorted Shapes Collection By Perimeter:\n");
            ShapeHelper.PrintShapes(Shapes);

            // Serialize to Json
            ShapeHelper.SerializeToJson(Shapes, @"d:\Shapes.json");
        }
    }
}