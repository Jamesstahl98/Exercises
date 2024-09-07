namespace Lab1Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDoubleCharactersAsGreen("Hello World!");
        }
        static void PrintStringUntilSpecifiedCharacter(string input, char stopChar = ' ')
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == stopChar)
                {
                    break;
                }
                Console.Write(input[i]);
            }

            Console.WriteLine();
        }

        static void PrintStringNewLineOnSpecifiedCharacter(string input, char stopChar = ' ')
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == stopChar)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(input[i]);
                }
            }

            Console.WriteLine();
        }

        static void ReplaceEvenIndexAsSpecifiedCharacter(string input, char replacementChar = '*')
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(replacementChar);
                }
                else
                {
                    Console.Write(input[i]);
                }
            }

            Console.WriteLine();
        }

        static void PrintSpecifiedCharactersAsGreenAndRed(string input, char greenChar = 'o', char redChar = 'l')
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString().ToUpper() == greenChar.ToString().ToUpper())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (input[i].ToString().ToUpper() == redChar.ToString().ToUpper())
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.Write(input[i]);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        static void PrintDoubleCharactersAsGreen(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (i < input.Length-1 && input[i] == input[i+1])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(input[i]);
                    Console.Write(input[i+1]);
                    i++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(input[i]);
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}

