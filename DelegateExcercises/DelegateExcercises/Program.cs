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
PrintStringArray(cities, getUpperCase);
PrintStringArray(cities, getFirstThreeLetters);
PrintStringArray(cities, getLength);

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

static void PrintStringArray(string[] array, Func<string, string> modifier)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(modifier(array[i]));
    }
}

public delegate string FullNameDelegate(string firstName, string lastName);