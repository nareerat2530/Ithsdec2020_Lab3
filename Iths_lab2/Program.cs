using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using Figure;

namespace Iths_lab2
{
    internal class Program
    {
        private static readonly List<Shape> ShapeList = new List<Shape>();

        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write($"20 random shapes are :");
            Console.WriteLine();
            PrintOutAllTheShape();
            Console.WriteLine();
            Console.WriteLine("_______________________________________________________________________");
            Console.WriteLine();
            Console.WriteLine($"Total Circumference of Triangle is {CalculateTriangleCircumference(ShapeList)}");
            Console.WriteLine($"\nThe average area of all the shapes is {CalculateAverageAreaOfAllShape(ShapeList)}");
            Console.WriteLine($"\nThe biggest volume of all the shapes is {FindBiggestVolumeOfAllTheShape(ShapeList)}");
            Console.WriteLine();
            PrintOutTriangle();
            Console.WriteLine("\n_____________________________________________________________________");
        }
        private static void PrintOutAllTheShape()
        {
            for (var i = 0; i < 20; i++)
            {
                ShapeList.Add(Shape.GenerateShape());
            }
            foreach (var shape in ShapeList)
            {
                Console.WriteLine(shape);
            }
        }
        private static float CalculateTriangleCircumference(List<Shape> listOfShapes)
        {
            var totalTriangleCircumference = 0.00f;
            foreach (var shapes in listOfShapes)
            {
                if (shapes is Triangle t)
                {
                    totalTriangleCircumference += t.Circumference;
                } 
            }
            return totalTriangleCircumference;
        }
        private static float CalculateAverageAreaOfAllShape(List<Shape> listOfShape)
        {
            var averageArea = listOfShape.Sum(shapes => shapes.Area);
            var totalAverageArea = averageArea / ShapeList.Count;
            return totalAverageArea;
        }
        private static float FindBiggestVolumeOfAllTheShape(List<Shape> listOfShapes)
        {
            var maxVolume = 0.00f;
            foreach (var shapes in listOfShapes)
            {
                if (shapes is not Shape3D s || !(s.Volume > maxVolume)) continue;
                maxVolume = s.Volume;
            }
            return maxVolume;
        }
        private static void PrintOutTriangle()
        {
            var triangle = new Triangle(new Vector2(3.25f,6.77f), new Vector2(4.56f,6.41f), new Vector2(2.05f, 3.58f));
            Console.WriteLine("Triangle with points at coordinates: ");
            foreach (var t in triangle)
            {
                Console.Write($"{t}  ");
            }
        }
    }
}




    
