namespace Lab1Prep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintInputAsRedUntilSameCharacterFound();

            Console.ReadLine();
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
                if (i < input.Length - 1 && input[i] == input[i + 1])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(input[i]);
                    Console.Write(input[i + 1]);
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
        static void PrintEachCharacterGreenDoubleCharacters(string input = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?", char doubleCharacters = 'o')
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (i < input.Length - 1 && input[i] == doubleCharacters && input[i + 1] == doubleCharacters)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(input.Substring(i, 2));
                    i++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(input[i]);
                }
            }
        }

        static void PrintSpecifiedWordAsGreen(string input = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?", string greenWord = "chuck")
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (i < input.Length - greenWord.Length && input.Substring(i, greenWord.Length) == greenWord)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(input.Substring(i, greenWord.Length));
                    i += greenWord.Length-1;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(input[i]);
                }
            }
        }

        static void LetterPyramid(string input = "Hello world!")
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(input[i]);
                }
                Console.WriteLine();
            }
        }

        static void WordPyramid(string input = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?")
        {
            string[] inputArray = input.Split(' ');
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{inputArray[i]} ");
                }
                Console.WriteLine();
            }
        }

        static void WordPyramidTwo(string input = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?")
        {
            string[] inputArray = input.Split(' ');
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{inputArray[j]} ");
                }
                Console.WriteLine();
            }
        }

        static void PrintInputWithIncreasingRedWords(string input = "How much wood would a woodchuck chuck if a woodchuck could chuck wood?")
        {
            string[] inputArray = input.Split(' ');
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    if(j <= i)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }

                    Console.Write($"{inputArray[j]} ");
                }
                Console.WriteLine();
            }
        }

        static void PrintInputFiveRedCharacters(string input = "abcdefghijklmnopqrstuvwxyz")
        {
            for (int i = 0; i < input.Length-5; i++)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (j <= i+5 && j >=i)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }

                    Console.Write(input[j]);
                }
                Console.WriteLine();
            }
        }

        static void PrintInputAsRedUntilSameCharacterFound(string input = "aasjdlaksdf")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < input.Length; i++)
            {
                if(i > 1)
                {
                    if (input[i - 1] == input[0])
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
                Console.Write(input[i]);
            }
        }

        static void PrintInputAsRedUntilSameCharacterFoundForAll(string input = "123783749238419283")
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Gray;

                for (int j = 0; j < input.Length; j++)
                {
                    if(j == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    if(j > 0)
                    {
                        if (input[i] == input[j-1] && j-1 != i)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                    }
                    Console.Write(input[j]);
                }
                Console.WriteLine();
            }
        }
    }
}

