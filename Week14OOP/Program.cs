Console.WriteLine("Name your dog:");
string mydogname = Console.ReadLine();
Dog mydog = new Dog(mydogname);

Dog neighboursdog = new Dog("Good Girl");

Console.WriteLine($"My dogs name is {mydog.Name}");
Console.WriteLine($"My neighbours dogs name is {neighboursdog.Name}");

mydog.Rename("Bad Boy");

while (mydog.Levelofhappiness != 5)
{
    mydog.bark();
}

mydog.wagtail();

class Dog
{
    private string _name; //field
    private int _levelofhappiness;

    //constructor
    public Dog(string name)
    {
        _name = name;
        _levelofhappiness = 0;
    }

    //getter
    public string Name 
    { 
        get { return _name; } 
    }

    public int Levelofhappiness
    {
        get { return _levelofhappiness; }
    }

    public void Rename(string newname)
    {
        _name = newname;
        Console.WriteLine($"Your dog has been renamed to {newname}");
    }

    public void bark()
    {
        Console.WriteLine("Auh auh!");
        _levelofhappiness ++;
    }

    public void wagtail()
    {
        Console.WriteLine("*wiggle wiggle*");
        _levelofhappiness++;
    }
}

