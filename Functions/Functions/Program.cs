using System.Reflection.Metadata.Ecma335;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringsOfNumbers = GetTextFromNumbers(6543);
            for (int i = 0; i < stringsOfNumbers.Length; i++)
            {
                Console.WriteLine(stringsOfNumbers[i]);
            }
            Console.ReadLine();
        }
        static void PrintName(string firstName, string lastName)
        {
            Console.WriteLine($"{firstName} {lastName}");
        }

        static string GetName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }

        static bool CheckIfStringIsLongerThanInt(string str, int num)
        {
            if(str.Length > num)
            {
                return true;
            }
            return false;
        }

        static double ConvertCelsiusToFahr(double celcius)
        {
            return celcius*1.8 + 32;
        }

        static string SeparateLettersInString(string str)
        {
            string stringToReturn = str;
            
            for (int i = 1; i < str.Length*2-1; i+=2)
            {
                stringToReturn = stringToReturn.Insert(i, "-");
            }
            
            return stringToReturn;
        }

        static string JoinString(char character, string[] stringArray)
        {
            string stringToReturn = "";

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringToReturn += stringArray[i];
                if(i < stringArray.Length -1)
                {
                    stringToReturn += character;
                }
            }
            return stringToReturn;
        }

        static double GetAverageValue(int[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum / numbers.Length;
        }

        static string[] GetTextFromNumbers(int number)
        {
            string[] digitStrings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int[] digits = number.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            string[] arrayToReturn = new string[digits.Length];

            for (int i = 0; i < arrayToReturn.Length; i++)
            {
                arrayToReturn[i] = digitStrings[digits[i]];
            }

            return arrayToReturn;
        }
    }
}
