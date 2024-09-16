var mySelf = new Person();
mySelf.firstName = "James";
mySelf.lastName = "Ståhl";
mySelf.mother = new Person();
mySelf.mother.firstName = "Åsa";
mySelf.mother.lastName = "Ståhl";
mySelf.father = new Person();

mySelf.SetLength(1.81);
mySelf.SetWeight(69);

Console.WriteLine(mySelf.GetBMI());

Console.WriteLine(mySelf.GetSelfAndParents());


static Person[] CreateAndGetTwoPersons()
{
    Person[] persons = new Person[2];

    var firstPerson = new Person();
    var secondPerson = new Person();
    persons[0] = firstPerson;
    persons[1] = secondPerson;

    return persons;
}

public class Person()
{
    public string firstName;
    public string lastName;

    public Person father;
    public Person mother;

    private double length;
    private double weight;

    public void SetLength(double length)
    {
        this.length = length;
    }

    public double GetLength()
    {
        return length;
    }

    public void SetWeight(double weight)
    {
        this.weight = weight;
    }

    public double GetWeight()
    {
        return weight;
    }

    public double GetBMI()
    {
        return weight / (Math.Pow(2, length));
    }

    public string GetFullName()
    {
        if (firstName == null)
        {
            return "unknown";
        }

        return firstName + " " + lastName;
    }

    public string GetFullName(string title)
    {
        if (firstName == null)
        {
            return "unknown";
        }

        return title + " " + firstName + " " + lastName;
    }

    public string GetFullNameReverse()
    {
        string fullName = GetFullName();
        char[] fullNameChars = fullName.ToCharArray();
        Array.Reverse(fullNameChars);
        return new string(fullNameChars);
    }

    public string GetSelfAndParents()
    {
        return $"{GetFullName()} - Mother {mother.GetFullName()} - Father {father.GetFullName()}";
    }
}
