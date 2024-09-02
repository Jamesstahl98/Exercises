using System.Reflection.Metadata.Ecma335;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SeparateLettersInString("abcd"));
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
    }
}
