using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MoveCharacter();
            //Random rand = new Random();
            //int numberOfRectangles = rand.Next(1, 11);
            //for (int i = 0; i < numberOfRectangles; i++)
            //{
            //    DrawBox(rand.Next(3, 10), 
            //        rand.Next(3, 10), 
            //        rand.Next(0, Console.WindowWidth), 
            //        rand.Next(0, Console.WindowHeight));
            //Thread.Sleep(200);
            //}


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

        static string[] GetTextFromInts(int number)
        {
            string[] digitStrings = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int[] digits = GetArrayOfInts(number);
            string[] arrayToReturn = new string[digits.Length];

            for (int i = 0; i < arrayToReturn.Length; i++)
            {
                arrayToReturn[i] = digitStrings[digits[i]];
            }

            return arrayToReturn;
        }

        static string GetTextFromUShort(ushort number)
        {
            return "";
        }

        static int[] GetIndexesOf(string text, char c)
        {
            char[] charsInText = text.ToCharArray();
            List<int> indexesOfChar = new List<int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (charsInText[i] == c)
                {
                    indexesOfChar.Add(i);
                }
            }

            int[] indexesToReturn = indexesOfChar.ToArray();

            return indexesToReturn;
        }

        static int[] GetArrayOfInts(int number)
        {
            int[] digits = number.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            return digits;
        }

        static int ThrowDice(int sides = 6)
        {
            Random rand = new Random();

            int result = rand.Next(1, sides);
            return result;
        }

        static int ThrowMultipleDice(int number, int sides = 6)
        {
            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                sum += ThrowDice(sides);
            }
            return sum;
        }

        static void DrawBox(int width, int height, int left, int top)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.SetCursorPosition(left + j, top + i);
                    if (i == 0 || i == height-1 || j == 0 || j == width-1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
        }

        static void MoveCharacter()
        {
            ConsoleKeyInfo cki;

            int width = 9;
            int height = 9;

            int posX = width / 2;
            int posY = height / 2;

            DrawBox(width, height, 0, 0);
            Console.SetCursorPosition(posX, posY);
            Console.Write("@");
            do
            {
                while (Console.KeyAvailable == false)
                {
                    Thread.Sleep(250);
                }

                cki = Console.ReadKey(true);
                Console.SetCursorPosition(posX, posY);
                if (cki.Key == ConsoleKey.LeftArrow && posX > 1)
                {
                    Console.Write("-");
                    posX -= 1;
                }
                else if (cki.Key == ConsoleKey.RightArrow && posX < width - 2)
                {
                    Console.Write("-");
                    posX += 1;
                }
                else if (cki.Key == ConsoleKey.UpArrow && posY > 1)
                {
                    Console.Write("-");
                    posY -= 1;
                }
                else if (cki.Key == ConsoleKey.DownArrow && posY < height - 2)
                {
                    Console.SetCursorPosition(posX, posY);
                    Console.Write("-");
                    posY += 1;
                }

                Console.SetCursorPosition(posX, posY);
                Console.Write("@");
            } while (cki.Key != ConsoleKey.Enter);
            
            Console.SetCursorPosition(width, height);
        }
    }
}
