using System;
using CSSEClass;

namespace CSSEApp
{
    class Program
    {
        static void Main(string[] args)
        {   
            MathOperations mathOperations = new MathOperations();
            // Wiskundige berekeningen
            MathOperations.MultiplicationTable(5);
            MathOperations.Sum(10, 20);
            MathOperations.Subtraction(50, 30);
            MathOperations.Division(100, 4);
            MathOperations.Multiplication(8, 7);
            MathOperations.Modulo(17, 5);
            MathOperations.Exponentiation(2, 10);

            // Oppervlaktebereken       ing
            MathOperations.AreaTriangle(5, 7);
            MathOperations.AreaRectangle(10, 15);
            MathOperations.AreaSquare(6);
            MathOperations.AreaParallelogram(8, 12);
            MathOperations.AreaRhombus(10, 6);
            MathOperations.AreaTrapezium(6, 8, 5);
            MathOperations.AreaCircle(5);

            // Omtrekberekening
            MathOperations.PerimeterTriangle(5, 7, 10);
            MathOperations.PerimeterRectangle(10, 15);
            MathOperations.PerimeterSquare(6);
            MathOperations.PerimeterParallelogram(8, 12);
            MathOperations.PerimeterRhombus(10);
            MathOperations.PerimeterTrapezium(6, 8, 5, 10);
            MathOperations.PerimeterCircle(5);

            // Volumeberekening
            MathOperations.VolumeCube(4);
            MathOperations.VolumeCylinder(5, 10);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            


            DisplayRandomNumber();
            DisplayRandomNumberWithStartLimit();
            DisplayRandomNumberWithStartStopLimit();
            DisplayRandomNumbersArray();
            Console.WriteLine();

            DisplayRandomChar();
            DisplayRandomCharWithStartStopLimit();
            DisplayRandomCharsArray();
            Console.WriteLine();

            DisplaySimplePassword();
            DisplayMediumPassword();
            DisplayStrongPassword();

            
            Console.WriteLine("Druk op Enter om het programma af te sluiten.");
            Console.ReadLine();
        }

        static void DisplayRandomNumber()
        {
            Console.WriteLine("Genereren van willekeurig getal (zonder limiet):");
            int randomNumber = Generator.RandomNumber();
            Console.WriteLine($"Random Number: {randomNumber}");
            Console.WriteLine();
        }

        static void DisplayRandomNumberWithStartLimit()
        {
            Console.WriteLine("Genereren van willekeurig getal met startlimiet:");
            int startLimitNumber = Generator.RandomNumber(50);
            Console.WriteLine($"Random Number met startlimiet: {startLimitNumber}");
            Console.WriteLine();
        }

        static void DisplayRandomNumberWithStartStopLimit()
        {
            Console.WriteLine("Genereren van willekeurig getal met start- en stoplimiet:");
            int startStopLimitNumber = Generator.RandomNumber(300, 500);
            Console.WriteLine($"Random Number met start- en stoplimiet: {startStopLimitNumber}");
            Console.WriteLine();
        }

        static void DisplayRandomNumbersArray()
        {
            Console.WriteLine("Genereren van willekeurige getallen als array:");
            int[] randomNumbers = Generator.RandomNumbers(3);
            foreach (int num in randomNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
        }

        static void DisplayRandomChar()
        {
            Console.WriteLine("Genereren van willekeurig karakter (zonder limiet):");
            char randomChar = Generator.RandomChar();
            Console.WriteLine($"Random Char: {randomChar}");
            Console.WriteLine();
        }

        static void DisplayRandomCharWithStartStopLimit()
        {
            Console.WriteLine("Genereren van willekeurig karakter met start- en stoplimiet:");
            char startStopLimitChar = Generator.RandomChar('c', 'q');
            Console.WriteLine($"Random Char met start- en stoplimiet: {startStopLimitChar}");
            Console.WriteLine();
        }

        static void DisplayRandomCharsArray()
        {
            Console.WriteLine("Genereren van willekeurige karakters als array:");
            char[] randomChars = Generator.RandomChars(4);
            foreach (char ch in randomChars)
            {
                Console.WriteLine(ch);
            }
            Console.WriteLine();
        }

        static void DisplaySimplePassword()
        {
            Console.WriteLine("Genereren van eenvoudig wachtwoord:");
            string simplePassword = Generator.PasswordGenerator(8, false, false, false);
            Console.WriteLine($"Eenvoudig wachtwoord: {simplePassword}");
            Console.WriteLine();
        }

        static void DisplayMediumPassword()
        {
            Console.WriteLine("Genereren van gemiddeld wachtwoord:");
            string mediumPassword = Generator.PasswordGenerator(12, true, true, false);
            Console.WriteLine($"Gemiddeld wachtwoord: {mediumPassword}");
            Console.WriteLine();
        }

        static void DisplayStrongPassword()
        {
            Console.WriteLine("Genereren van sterk wachtwoord:");
            string strongPassword = Generator.PasswordGenerator(16, true, true, true);
            Console.WriteLine($"Sterk wachtwoord: {strongPassword}");
            Console.WriteLine();
        }

        static void DisplayExtremePassword()
        {
            Console.WriteLine("Genereren van extreem wachtwoord:");
            string extremePassword = Generator.PasswordGenerator(21, true, true, true);
            
        }
        
        
    }
}
