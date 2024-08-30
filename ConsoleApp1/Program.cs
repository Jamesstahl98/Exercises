using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            MultiplyTwoNumbers();
            //**************************VARIABLES**************************
            //Greet user
            void GreetUser()
            {
                Console.WriteLine("Write your name");
                string name = Console.ReadLine();
                Console.WriteLine($"Hello {name}");
                Console.ReadLine();
            }

            //Multiply 2 numbers
            void MultiplyTwoNumbers()
            {
                try
                {
                    Console.WriteLine("Write a number");
                    int firstNumber = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Write another number");
                    int secondNumber = Int32.Parse(Console.ReadLine());

                    Console.WriteLine($"{firstNumber} times {secondNumber} is {firstNumber * secondNumber}");
                    Console.ReadLine();
                }
                catch
                {

                }
            }

            //Verify Password
            void Password()
            {
                string password = "abc123";
                Console.WriteLine("Enter password");
                string passwordInput = Console.ReadLine();

                if (password == passwordInput)
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Incorrect");
                }
                Console.ReadLine();
            }

            //Check if number is higher than, lower than or equal to 100
            void HigherOrLowerThan100()
            {
                try
                {
                    Console.WriteLine("Write a number");
                    int userNumber = Int32.Parse(Console.ReadLine());
                    if (userNumber < 100)
                    {
                        Console.WriteLine("Your number is lower than 100");
                    }
                    else if (userNumber > 100)
                    {
                        Console.WriteLine("Your number is higher than 100");
                    }
                    else
                    {
                        Console.WriteLine("Your number is 100");
                    }
                    Console.ReadLine();
                }
                catch
                {

                }
            }

            //Double and half user input
            void DoubleAndHalf()
            {
                try
                {
                    Console.WriteLine("Write a number");
                    int num = Int32.Parse(Console.ReadLine());

                    Console.WriteLine($"{num * 2} is double your number. {num / 2} is half your number");
                    Console.ReadLine();
                }
                catch
                {

                }
            }

            //Calculator
            void Calculator()
            {
                try
                {
                    double sum = 0;

                    Console.WriteLine("Write first number");
                    double firstNum = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Write operator");
                    string arithmeticOperator = Console.ReadLine();

                    Console.WriteLine("Write second number");
                    double secondNum = Int32.Parse(Console.ReadLine());

                    switch (arithmeticOperator)
                    {
                        case "+":
                            sum = firstNum + secondNum;
                            break;

                        case "-":
                            sum = firstNum - secondNum;
                            break;

                        case "*":
                            sum = firstNum * secondNum;
                            break;

                        case "/":
                            sum = firstNum / secondNum;
                            break;

                    }
                    Console.WriteLine(sum);
                    Console.ReadLine();
                }
                catch
                {

                }
                
            }

            //Sum and average value
            void SumAndAverage()
            {
                try
                {
                    List<int> numbers = new List<int>();
                    float sum = 0;
                    while (true)
                    {
                        Console.WriteLine("Write a number or press enter to exit");
                        try
                        {
                            int newNumber = Int32.Parse(Console.ReadLine());
                            numbers.Add(newNumber);
                            sum += newNumber;
                        }
                        catch
                        {
                            break;
                        }
                        Console.Clear();
                        Console.WriteLine($"The sum of your numbers is {sum}");
                    }
                    Console.WriteLine($"The Average value of your numbers is {sum / numbers.Count}");
                    Console.ReadLine();
                }
                catch
                {

                }
                
            }

            //**************************INDEXING**************************
            //Print each character in name
            void PrintLetter()
            {
                Console.WriteLine("Write your name!");
                string name = Console.ReadLine();
                char[] c = name.ToCharArray();

                for (int i = 0; i < c.Length; i++)
                {
                    Console.WriteLine(c[i]);
                }
                Console.ReadLine();
            }

            //Remove vowels
            void RemoveVowels()
            {
                Console.WriteLine("Write your name!");
                string name = Console.ReadLine();
                string output = name.Replace("a", string.Empty)
                                         .Replace("e", string.Empty)
                                         .Replace("i", string.Empty)
                                         .Replace("o", string.Empty)
                                         .Replace("u", string.Empty)
                                         .Replace("y", string.Empty);
                Console.WriteLine(output);
                Console.ReadLine();
            }

            //Number to words
            void NumbersToWords()
            {
                try
                {
                    string[] numbers = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

                    while (true)
                    {
                        Console.Write("Write a number: ");
                        int num = Int32.Parse(Console.ReadLine());

                        if (num < numbers.Length + 1 && num > 0)
                        {
                            Console.WriteLine(numbers[num - 1]);
                            break;
                        }

                        else
                        {
                            Console.WriteLine("number is too high or too low, try again.");
                        }
                    }
                    Console.ReadLine();
                }
                catch
                {

                }
            }
            //Reverse string
            void ReverseString()
            {
                Console.WriteLine("Write something");
                string s = Console.ReadLine();
                char[] c = s.ToCharArray();
                char[] reverseC = new char[s.Length];

                for (int i = 0; i < c.Length; i++)
                {
                    char tempC1 = c[i];
                    char tempC2 = c[c.Length - i - 1];
                    reverseC[c.Length - i - 1] = tempC1;
                    reverseC[i] = tempC2;
                }
                string reverseS = new string(reverseC);

                Console.WriteLine(reverseS);
                Console.ReadLine();
            }

            //Palindrome
            void CheckIfPalindrome()
            {
                Console.WriteLine("Write something");
                string s = Console.ReadLine();
                char[] c = s.ToCharArray();
                char[] reverseC = new char[s.Length];

                for (int i = 0; i < c.Length; i++)
                {
                    char tempC1 = c[i];
                    char tempC2 = c[c.Length - i - 1];
                    reverseC[c.Length - i - 1] = tempC1;
                    reverseC[i] = tempC2;
                }
                string reverseS = new string(reverseC);

                if (s == reverseS)
                {
                    Console.WriteLine("This is a palindrome");
                }

                else
                {
                    Console.WriteLine("This is not a palindrome");
                }
                Console.ReadLine();
            }

            //Delayed print
            void DelayPrint()
            {
                string[] strings = new string[0];

                while (true)
                {
                    string[] tempStrings = new string[strings.Length + 1];
                    for (int i = 0; i < strings.Length; i++)
                    {
                        tempStrings[i] = strings[i];
                    }

                    tempStrings[tempStrings.Length - 1] = Console.ReadLine();

                    strings = tempStrings;

                    Console.WriteLine(strings[0]);

                    Console.Clear();

                    if (strings.Length < 10)
                    {
                        Console.WriteLine("You have not written 10 entries yet");
                    }
                    else
                    {
                        Console.WriteLine(strings[strings.Length - 10]);
                    }
                }
                Console.ReadLine();
            }

            //Letter pyrmid
            void LetterPyramid()
            {
                string str = "Hello World";
                char[] characters = str.ToCharArray();

                for (int i = 0; i < characters.Length + 1; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(characters[j]);
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }

            //Coloured text
            void PrintColouredText()
            {
                Console.WriteLine("Write a word");
                char[] word = Console.ReadLine().ToCharArray();

                Console.WriteLine("Write a letter");
                char[] letter = Console.ReadLine().ToCharArray();

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == letter[0])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.Write(word[i]);
                }
                Console.ReadLine();
            }

            //Start- & Stopindex Coloured text
            void ColouredTextBetweenIndex()
            {
                try
                {
                    Console.WriteLine("Write a word");
                    char[] word = Console.ReadLine().ToCharArray();

                    Console.WriteLine("Write a start index");
                    int startIndex = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Write a stop index");
                    int stopIndex = Int32.Parse(Console.ReadLine());

                    for (int i = 0; i < word.Length; i++)
                    {
                        if (i >= stopIndex)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else if (i >= startIndex - 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.Write(word[i]);
                    }
                    Console.ReadLine();
                }
                catch
                {

                }
            }

            //Switch color on letter
            void PrintTextSwitchColorOnLetter()
            {
                try
                {
                    Console.WriteLine("Write a word");
                    char[] word = Console.ReadLine().ToCharArray();

                    Console.WriteLine("Write a letter");
                    char[] letter = Console.ReadLine().ToCharArray();

                    Console.ForegroundColor = ConsoleColor.Gray;

                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == letter[0] && Console.ForegroundColor == ConsoleColor.Red)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else if (word[i] == letter[0] && Console.ForegroundColor == ConsoleColor.Gray)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.Write(word[i]);
                    }
                    Console.ReadLine();
                }
                catch
                {

                }
            }

            //**************************LOOPS**************************
            void Print20To30()
            {
                for (int i = 20; i <= 30; i++)
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();
            }

            void PrintEvenNumbers()
            {
                for (int i = 0; i <= 30; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.ReadLine();
            }

            //Print hello if divisible by specified number
            void PrintHelloIfDivisible(int division = 3)
            {
                for (int i = 0; i <= 30; i++)
                {
                    if (i % division == 0)
                    {
                        Console.WriteLine("Hello");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.ReadLine();
            }

            void TimesTable()
            {
                try
                {
                    Console.WriteLine("Write a number");
                    int number = Int32.Parse(Console.ReadLine());
                    Console.Clear();

                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine(number * i);
                    }
                    Console.ReadLine();
                }
                catch
                {

                }
            }

            void SumBetweenOneAndInput()
            {
                try
                {
                    Console.WriteLine("Write a number");
                    int number = Int32.Parse(Console.ReadLine());
                    int sum = 0;

                    Console.Clear();

                    for (int i = 0; i <= number; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine(sum);
                    Console.ReadLine();
                }
                catch
                {

                }
            }

            void Double64Times()
            {
                double num = 1;

                for (int i = 1; i <= 64; i++)
                {
                    num *= 2;
                    Console.WriteLine(num);
                }
                Console.WriteLine(num);
                Console.ReadLine();
            }

            //Print box based on input dimensions
            void PrintBox()
            {
                try
                {
                    Console.WriteLine("Assign width");
                    int width = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Assign height");
                    int height = Int32.Parse(Console.ReadLine());

                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            Console.Write("X");
                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();
                }
                catch
                {

                }
            }

            void PrintBoxAlternatingCharacters()
            {
                try
                {
                    Console.WriteLine("Assign width");
                    int width = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Assign height");
                    int height = Int32.Parse(Console.ReadLine());

                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (j % 2 == 0)
                            {
                                Console.Write("X");
                            }
                            else
                            {
                                Console.Write("O");
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();
                }
                catch
                {

                }
            }

            void PrintHollowBox()
            {
                try
                {
                    Console.WriteLine("Assign width");
                    int width = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Assign height");
                    int height = Int32.Parse(Console.ReadLine());

                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (i == 0 || i == height - 1 || j == 0 || j == width - 1)
                            {
                                Console.Write("X");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();
                }
                catch
                {

                }
            }

            void NumberPyramid()
            {
                for (int i = 1; i < 10; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }

            void NineNumberPyramids()
            {
                for (int i = 1; i < 10; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        for (int k = 1; k <= j; k++)
                        {
                            Console.Write(k);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }

            //List first 20 primenumbers
            void ListPrimeNumbers()
            {
                Console.WriteLine("The first 20 prime number are: ");
                int i = 0;
                int primeNumberCounter = 0;

                while (primeNumberCounter < 20)
                {
                    int counter = 0;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            counter++;
                            break;
                        }
                    }

                    if (counter == 0 && i != 1)
                    {
                        Console.Write(i + " ");
                        primeNumberCounter++;

                        if (primeNumberCounter >= 20)
                        {
                            break;
                        }
                    }
                    i++;
                }
                Console.ReadKey();
            }

            void GuessNumberForComputer()
            {
                Random rand = new Random();
                int secretNumber = rand.Next(1, 101);
                List<int> tooHighGuesses = new List<int>();
                List<int> tooLowGuesses = new List<int>();

                int guess = rand.Next(1, 101);

                while (guess != secretNumber)
                {
                    if (guess != secretNumber)
                    {
                        int lowestTooHigh = 101;
                        int highestTooLow = 1;
                        if (guess > secretNumber)
                        {
                            tooHighGuesses.Add(guess);
                            Console.WriteLine(guess + " was too high");
                        }
                        else
                        {
                            tooLowGuesses.Add(guess + 1);
                            Console.WriteLine(guess + " was too low");
                        }

                        for (int i = 0; i < tooHighGuesses.Count; i++)
                        {
                            if (tooHighGuesses[i] < lowestTooHigh)
                            {
                                lowestTooHigh = tooHighGuesses[i];
                            }
                        }
                        for (int i = 0; i < tooLowGuesses.Count; i++)
                        {
                            if (tooLowGuesses[i] > highestTooLow)
                            {
                                highestTooLow = tooLowGuesses[i];
                            }
                        }

                        guess = rand.Next(highestTooLow, lowestTooHigh);
                    }

                    if (guess == secretNumber)
                    {
                        break;
                    }
                }
                Console.WriteLine(secretNumber + " was the correct guess");
                Console.ReadLine();
            }



            //Rock, paper scissors vs computer
            void RockPaperScissors()
            {
                Random rand = new Random();
                int playerWins = 0;
                int playerLosses = 0;
                int draws = 0;

                while (true)
                {
                    try
                    {
                        int computerChoiceIndex = rand.Next(0, 3);

                        Console.Clear();
                        Console.WriteLine("Write your choice: rock, paper or scissors.\r\nPress enter without typing to exit");
                        string playerChoice = Console.ReadLine().ToLower();
                        Console.Clear();

                        if (playerChoice == "")
                        {
                            break;
                        }
                        else if (playerChoice == "rock".ToLower())
                        {
                            if (computerChoiceIndex == 0)
                            {
                                draws += 1;
                                Console.WriteLine("Computer chose rock. Draw");
                            }
                            else if (computerChoiceIndex == 1)
                            {
                                playerLosses += 1;
                                Console.WriteLine("Computer chose paper. You lost");
                            }
                            else if (computerChoiceIndex == 2)
                            {
                                playerWins += 1;
                                Console.WriteLine("Computer chose scissors, You won");
                            }
                        }
                        else if (playerChoice == "paper".ToLower())
                        {
                            if (computerChoiceIndex == 0)
                            {
                                playerWins += 1;
                                Console.WriteLine("Computer chose rock, You won");
                            }
                            else if (computerChoiceIndex == 1)
                            {
                                draws += 1;
                                Console.WriteLine("Computer chose paper. Draw");
                            }
                            else if (computerChoiceIndex == 2)
                            {
                                playerLosses += 1;
                                Console.WriteLine("Computer chose scissors, You lost");
                            }
                        }
                        else if (playerChoice == "scissors".ToLower())
                        {
                            if (computerChoiceIndex == 0)
                            {
                                playerLosses += 1;
                                Console.WriteLine("Computer chose rock, You lost");
                            }

                            else if (computerChoiceIndex == 1)
                            {
                                playerWins += 1;
                                Console.WriteLine("Computer chose paper. You won");
                            }

                            else if (computerChoiceIndex == 2)
                            {
                                draws += 1;
                                Console.WriteLine("Computer chose scissors. Draw");
                            }
                        }

                        Console.WriteLine(playerWins + " player wins,\r\n"
                                    + playerLosses + " player losses\r\n"
                                    + draws + " draws\r\n" +
                                    "press enter to continue");
                        Console.ReadLine();
                    }
                    catch
                    {

                    }
                }
                Console.ReadLine();
            }
        
        }
    }
}
