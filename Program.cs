using System;

// Base Class
class Animal
{
    private string name; // only accessible within this class
    protected string type; // accessible from derived classes
    public string color; // accessible from any class

    public void setName(string name)
    {
        this.name = name;
    }
    public virtual string getName()
    {
        return this.name;
    }
    public void setType(string type)
    {
        this.type = type;
    }
    public virtual string getType()
    {
        return this.type;
    }
}

// Derived class from Animal
class AnimalInfo : Animal
{
    // Fields
    private int age;
    protected string breed;
    public double weight;

    // Constructor
    public AnimalInfo(string name, int age, string breed, double weight)
    {
        setName(name);
        this.age = age;
        this.breed = breed;
        this.weight = weight;
    }

    // Methods for fields
    public void setAge(int age)
    {
        this.age = age;
    }
    public int getAge()
    {
        return this.age;
    }

    public void setBreed(string breed)
    {
        this.breed = breed;
    }
    public string getBreed()
    {
        return this.breed;
    }

    // Overriding base class methods
    public override string getName()
    {
        return $"Animal's name: {base.getName()}";
    }

    public override string getType()
    {
        return $"Animal's type: {base.getType()}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Prompt user to input the number of animals
        Console.Write("Enter the number of animals: ");
        int numAnimals = int.Parse(Console.ReadLine());

        // Loop to input information for each animal
        for (int i = 1; i <= numAnimals; i++)
        {
            Console.WriteLine($"\nEnter information for Animal {i}:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Breed: ");
            string breed = Console.ReadLine();

            Console.Write("Weight (kg): ");
            double weight = double.Parse(Console.ReadLine());

            // Create an object from the derived class using the parameterized constructor
            AnimalInfo myAnimal = new AnimalInfo(name, age, breed, weight);

            // Displaying information
            Console.WriteLine(myAnimal.getName());
            Console.WriteLine(myAnimal.getType());
            Console.WriteLine($"Age: {myAnimal.getAge()} years");
            Console.WriteLine($"Breed: {myAnimal.getBreed()}");
            Console.WriteLine($"Weight: {myAnimal.weight} kg");
        }
    }
}
