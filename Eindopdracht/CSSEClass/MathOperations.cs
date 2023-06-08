using System;

namespace CSSEClass
{
    public class MathOperations
    {
        public static void MultiplicationTable(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }
        }

        public static int Sum(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"Sum: {x} + {y} = {result}");
            return result;
        }

        public static int Subtraction(int x, int y)
        {
            int result = x - y;
            Console.WriteLine($"Subtraction: {x} - {y} = {result}");
            return result;
        }

        public static int Division(int x, int y)
        {
            int result = x / y;
            Console.WriteLine($"Division: {x} / {y} = {result}");
            return result;
        }

        public static int Multiplication(int x, int y)
        {
            int result = x * y;
            Console.WriteLine($"Multiplication: {x} * {y} = {result}");
            return result;
        }

        public static int Modulo(int x, int y)
        {
            int result = x % y;
            Console.WriteLine($"Modulo: {x} % {y} = {result}");
            return result;
        }

        public static double Exponentiation(double x, double y)
        {
            double result = Math.Pow(x, y);
            Console.WriteLine($"Exponentiation: {x} ^ {y} = {result}");
            return result;
        }

        public static double AreaTriangle(double baseLength, double height)
        {
            double area = 0.5 * baseLength * height;
            Console.WriteLine($"Area Triangle: 0.5 * {baseLength} * {height} = {area}");
            return area;
        }

        public static double AreaRectangle(double length, double width)
        {
            double area = length * width;
            Console.WriteLine($"Area Rectangle: {length} * {width} = {area}");
            return area;
        }

        public static double AreaSquare(double side)
        {
            double area = side * side;
            Console.WriteLine($"Area Square: {side} * {side} = {area}");
            return area;
        }

        public static double AreaParallelogram(double baseLength, double height)
        {
            double area = baseLength * height;
            Console.WriteLine($"Area Parallelogram: {baseLength} * {height} = {area}");
            return area;
        }

        public static double AreaRhombus(double diagonal1, double diagonal2)
        {
            double area = 0.5 * diagonal1 * diagonal2;
            Console.WriteLine($"Area Rhombus: 0.5 * {diagonal1} * {diagonal2} = {area}");
            return area;
        }

        public static double AreaTrapezium(double base1, double base2, double height)
        {
            double area = 0.5 * (base1 + base2) * height;
            Console.WriteLine($"Area Trapezium: 0.5 * ({base1} + {base2}) * {height} = {area}");
            return area;
        }

        public static double AreaCircle(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Area Circle: π * {radius} * {radius} = {area}");
            return area;
        }

        public static double PerimeterTriangle(double side1, double side2, double side3)
        {
            double perimeter = side1 + side2 + side3;
            Console.WriteLine($"Perimeter Triangle: {side1} + {side2} + {side3} = {perimeter}");
            return perimeter;
        }

        public static double PerimeterRectangle(double length, double width)
        {
            double perimeter = 2 * (length + width);
            Console.WriteLine($"Perimeter Rectangle: 2 * ({length} + {width}) = {perimeter}");
            return perimeter;
        }

        public static double PerimeterSquare(double side)
        {
            double perimeter = 4 * side;
            Console.WriteLine($"Perimeter Square: 4 * {side} = {perimeter}");
            return perimeter;
        }

        public static double PerimeterParallelogram(double baseLength, double side)
        {
            double perimeter = 2 * (baseLength + side);
            Console.WriteLine($"Perimeter Parallelogram: 2 * ({baseLength} + {side}) = {perimeter}");
            return perimeter;
        }

        public static double PerimeterRhombus(double side)
        {
            double perimeter = 4 * side;
            Console.WriteLine($"Perimeter Rhombus: 4 * {side} = {perimeter}");
            return perimeter;
        }

        public static double PerimeterTrapezium(double base1, double base2, double side1, double side2)
        {
            double perimeter = base1 + base2 + side1 + side2;
            Console.WriteLine($"Perimeter Trapezium: {base1} + {base2} + {side1} + {side2} = {perimeter}");
            return perimeter;
        }

        public static double PerimeterCircle(double radius)
        {
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine($"Perimeter Circle: 2 * π * {radius} = {perimeter}");
            return perimeter;
        }

        public static double VolumeCube(double side)
        {
            double volume = Math.Pow(side, 3);
            Console.WriteLine($"Volume Cube: {side} ^ 3 = {volume}");
            return volume;
        }

        public static double VolumeCylinder(double radius, double height)
        {
            double volume = Math.PI * Math.Pow(radius, 2) * height;
            Console.WriteLine($"Volume Cylinder: π * {radius} ^ 2 * {height} = {volume}");
            return volume;
        }
    }
}