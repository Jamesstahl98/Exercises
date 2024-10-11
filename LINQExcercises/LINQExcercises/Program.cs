using System.Linq;

var people = new[]
{
    new { FirstName = "Sven",       LastName = "Larsson",   Age = 25,   Height = 180,   Weight = 70 },
    new { FirstName = "Lars",       LastName = "Larsson",   Age = 17,   Height = 175,   Weight = 65 },
    new { FirstName = "Bengt",      LastName = "Bengtsson", Age = 30,   Height = 191,   Weight = 90 },
    new { FirstName = "Sara",       LastName = "Andersson", Age = 32,   Height = 165,   Weight = 60 },
    new { FirstName = "Ulla",       LastName = "Johansson", Age = 68,   Height = 185,   Weight = 62 },
    new { FirstName = "Pernilla",   LastName = "Persson",   Age = 83,   Height = 170,   Weight = 62 },
    new { FirstName = "Olof",       LastName = "Olofsson",  Age = 62,   Height = 187,   Weight = 100 },
    new { FirstName = "Anna",       LastName = "Jansson",   Age = 35,   Height = 170,   Weight = 67 },
};

//***Excercise two***
var peopleBetween20and40 = people.Where(p => p.Age >= 20 && p.Age <= 40).ToList();
Console.WriteLine(peopleBetween20and40.Count);

//***Excercise three***
var peopleBetween20and40AgeAbove190Height = people.Where(p => p.Age >= 20 
&& p.Age <= 40 
&& p.Height > 190).ToList();
Console.WriteLine(peopleBetween20and40AgeAbove190Height.Count);

//***Excercise four***
var longerFirstNameThanLastName = people
    .Where(p => p.FirstName.Length >= p.LastName.Length)
    .Select(p => new {p.FirstName, p.LastName} ).ToList();

for (int i = 0; i < longerFirstNameThanLastName.Count; i++)
{
    Console.WriteLine($"{longerFirstNameThanLastName[i].FirstName} {longerFirstNameThanLastName[i].LastName}");
}

//***Excercise five***
//BMI = kg/m2
var peopleWithNameAndBMI = people
    .Select(p => new { p.FirstName, BMI = (MathF.Round(p.Weight / ((p.Height * p.Height) / 10_000f), 2)) }).ToList();

for (int i = 0; i < peopleWithNameAndBMI.Count; i++)
{
    Console.WriteLine($"{peopleWithNameAndBMI[i].FirstName} {peopleWithNameAndBMI[i].BMI}");
}

//***Excercise six***
Console.WriteLine();
var peopleWithBMI20to25 = peopleWithNameAndBMI
    .Where(p => p.BMI >= 20 && p.BMI <= 25).ToList();
for (int i = 0; i < peopleWithBMI20to25.Count; i++)
{
    Console.WriteLine($"{peopleWithBMI20to25[i].FirstName} {peopleWithBMI20to25[i].BMI}");
}

//***Excercise seven***
Console.WriteLine();
Func<int, int, float> BMI = (height, weight) => (MathF.Round(weight / ((height * height) / 10_000f), 2));
var BMI20to25Original = people
    .Where(p => BMI(p.Height, p.Weight) >= 20 && BMI(p.Height, p.Weight) <= 25).ToList();

for (int i = 0; i < BMI20to25Original.Count; i++)
{
    Console.WriteLine(BMI20to25Original[i].FirstName);
}

//***Excercise eight***
var userNamesList = people
    .Select(p => new { UserName = p.FirstName + p.Age, Category = p.Age >= 18 ? "adult" : "child" }).ToList();

for (int i = 0; i < userNamesList.Count; i++)
{
    Console.WriteLine($"{userNamesList[i].UserName} {userNamesList[i].Category}");
}

//***Excercise ten***
people = people.OrderBy(p => p.Age).ToArray();
for (int i = 0; i < people.Length; i++)
{
    Console.WriteLine(people[i].Age);
}
Console.WriteLine();

//***Excercise eleven***
people = people.OrderByDescending(p => p.Age).ToArray();
for (int i = 0; i < people.Length; i++)
{
    Console.WriteLine(people[i].Age);
}
Console.WriteLine();

//***Excercise eleven***
people = people.OrderBy(p => p.LastName).ThenBy(p => p.FirstName).ToArray();
for (int i = 0; i < people.Length; i++)
{
    Console.WriteLine($"{people[i].FirstName} {people[i].LastName}");
}
Console.WriteLine();

//***Excercise twelve***
var numbers = Enumerable.Range(1, 100_000_000_0);

var divisibleNumbers = numbers.AsParallel().Where(n => n % 3 == 0 || n % 5 == 0);

Console.WriteLine(divisibleNumbers.Last());

Console.ReadLine();