using System;
using System.Linq;
using System.Text;

namespace CSSEClass
{
    public class Generator
    {
        private static Random random = new Random();

        public static int RandomNumber()
        {
            return random.Next();
        }

        public static int RandomNumber(int minValue)
        {
            return random.Next(minValue, int.MaxValue);
        }

        public static int RandomNumber(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue + 1);
        }

        public static int[] RandomNumbers(int count)
        {
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next();
            }
            return numbers;
        }

        public static int[] RandomNumbers(int count, int minValue)
        {
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next(minValue, int.MaxValue);
            }
            return numbers;
        }

        public static int[] RandomNumbers(int count, int minValue, int maxValue)
        {
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next(minValue, maxValue + 1);
            }
            return numbers;
        }

        public static int[] RandomNumbers(int count, int[] chars)
        {
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                int index = random.Next(chars.Length);
                numbers[i] = chars[index];
            }
            return numbers;
        }

        public static char RandomChar()
        {
            int randomNumber = random.Next(0, 256);
            return (char)randomNumber;
        }

        public static char RandomChar(char minValue, char maxValue)
        {
            int minValueInt = (int)minValue;
            int maxValueInt = (int)maxValue;
            int randomNumber = random.Next(minValueInt, maxValueInt + 1);
            return (char)randomNumber;
        }

        public static char RandomChar(char[] chars)
        {
            int randomIndex = random.Next(0, chars.Length);
            return chars[randomIndex];
        }

        public static char[] RandomChars(int count)
        {
            char[] chars = new char[count];
            for (int i = 0; i < count; i++)
            {
                chars[i] = RandomChar();
            }
            return chars;
        } 

        public static char[] RandomChars(char minValue, char maxValue, int count)
        {
            char[] chars = new char[count];
            for (int i = 0; i < count; i++)
            {
                chars[i] = RandomChar(minValue, maxValue);
            }
            return chars;
        }

        public static char[] RandomChars(char[] availableChars, int count)
        {
            char[] chars = new char[count];
            for (int i = 0; i < count; i++)
            {
                int randomIndex = random.Next(0, availableChars.Length);
                chars[i] = availableChars[randomIndex];
            }
            return chars;
        }

        public static string PasswordGenerator(int length, bool includeUpperCase, bool includeNumbers, bool includeSpecialChars)
        {
            string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
            string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numberChars = "0123456789";
            string specialChars = "!@#$%^&*()";

            StringBuilder password = new StringBuilder();

            string allowedChars = lowercaseChars;
            if (includeUpperCase)
                allowedChars += uppercaseChars;
            if (includeNumbers)
                allowedChars += numberChars;
            if (includeSpecialChars)
                allowedChars += specialChars;

            for (int i = 0; i < length; i++)
            {
                int randomIndex = random.Next(0, allowedChars.Length);
                password.Append(allowedChars[randomIndex]);
            }
            return password.ToString();
        }
    }
}
