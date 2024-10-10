FullNameDelegate demoDelegate = GetFullName;

Func<string, string, string> getFullName = (firstName, lastName) => firstName + " " + lastName;

Func<string, string, string> getFullName2 = GetFullName2;

Console.WriteLine(demoDelegate("Per", "Persson"));

Console.WriteLine(GetFullName2("Bengt", "Bengtsson"));

PrintFullNames(getFullName2);

Action<int, int> printSum = (x, y) => Console.WriteLine(x + y);
printSum(1, 2);

Func<int, int, int> getSum = (x, y) => x + y;
Console.WriteLine(getSum(5, 4));

Func<string, string, string> getNumberOfLetters = (firstName, lastName) => $"firstName has {firstName.Length} letters, lastName has {lastName.Length} letters.";
PrintFullNames(getNumberOfLetters);

Func<string, string> getUpperCase = s => s.ToUpper();
Func<string, string> getFirstThreeLetters = s => (s[0].ToString() + s[1].ToString() + s[2].ToString());
Func<string, string> getLength = s => s.Length.ToString();
string[] cities = { "Göteborg", "Stockholm", "Malmö", "Halmstad", "Jönköping" };
Console.WriteLine("***Lambda string array***");
PrintStringArray(cities, getUpperCase);
PrintStringArray(cities, getFirstThreeLetters);
PrintStringArray(cities, getLength);

Func<int, bool> isNegative = n => n < 0;
Func<int, bool> isBetween10and20 = n => n >= 10 && n <= 20;
Func<int, bool> isEven = n => n % 2 == 0;
int[] numbers = { 1, 2, -5, -6, 15, 50, 10, 9, -20, -25 };
int[] negativeNumbers = PrintIntArray(numbers, isNegative);
int[] numbersBetween10and20 = PrintIntArray(numbers, isBetween10and20);
int[] evenNumbers = PrintIntArray(numbers, isEven);

Console.WriteLine("***Lambda int array***");
Console.WriteLine("***Negative Numbers***");
for (int i = 0; i < negativeNumbers.Length; i++)
{
    Console.WriteLine(negativeNumbers[i]);
}

Console.WriteLine("***Numbers between 10 and 20***");
for (int i = 0; i < numbersBetween10and20.Length; i++)
{
    Console.WriteLine(numbersBetween10and20[i]);
}

Console.WriteLine("***Even Numbers***");
for (int i = 0; i < evenNumbers.Length; i++)
{
    Console.WriteLine(evenNumbers[i]);
}

static string GetFullName(string firstName, string lastName)
{
    return $"{firstName} {lastName}";
}

static string GetFullName2(string firstName, string lastName)
{
    return $"{nameof(firstName)}: {firstName}\n{nameof(lastName)}: {lastName}";
}

static void PrintFullNames(Func<string, string, string> func)
{
    Console.WriteLine(func("namn","namnsson"));
    Console.WriteLine(func("bengt", "bengtsson"));
    Console.WriteLine(func("sven", "svensson"));
}

static void PrintStringArray(string[] strings, Func<string, string> modifier)
{
    for (int i = 0; i < strings.Length; i++)
    {
        Console.WriteLine(modifier(strings[i]));
    }
}

static int[] PrintIntArray(int[] numbers, Func<int, bool> modifier)
{
    List<int> newNumbers = new List<int>();
    for (int i = 0; i < numbers.Length; i++)
    {
        if (modifier(numbers[i]))
        {
            newNumbers.Add(numbers[i]);
        }
    }
    return newNumbers.ToArray();
}

public delegate string FullNameDelegate(string firstName, string lastName);