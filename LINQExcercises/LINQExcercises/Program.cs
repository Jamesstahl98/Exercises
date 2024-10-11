var people = new[]
{
    new { FirstName = "Lars",   LastName = "Larsson",   Age = 25,   Height = 180,   Weight = 70 },
    new { FirstName = "Sven",   LastName = "Svensson",  Age = 20,   Height = 175,   Weight = 65 },
    new { FirstName = "Bengt",  LastName = "Bengtsson", Age = 30,   Height = 191,   Weight = 75 },
    new { FirstName = "Sara",   LastName = "Andersson", Age = 32,   Height = 165,   Weight = 60 },
    new { FirstName = "Ulla",   LastName = "Johansson", Age = 68,   Height = 185,   Weight = 62 },
    new { FirstName = "Per",    LastName = "Persson",   Age = 83,   Height = 170,   Weight = 62 },
    new { FirstName = "Olof",   LastName = "Olofsson",  Age = 62,   Height = 187,   Weight = 80 },
    new { FirstName = "Anna",   LastName = "Jansson",   Age = 35,   Height = 170,   Weight = 67 },
};

var peopleBetween20and40 = new List<object>();
var peopleBetween20and40AgeAbove190Height = new List<object>();

for (int i = 0; i < people.Length; i++)
{
    if (people[i].Age >= 20 && people[i].Age <= 40)
    {
        peopleBetween20and40.Add(people[i]);
        if (people[i].Height > 190)
        {
            peopleBetween20and40AgeAbove190Height.Add(people[i]);
        }
    }
}