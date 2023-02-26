using System;

namespace animalclassawesomewin
{
    abstract class Animal
    {
        // Property
        public abstract string Name { get; set; }
        // Methods
        public abstract string Describe();
        public string whatAmI()
        {
            return "I am an animal";
        }
    }

    class Dog : Animal
    {
        public override string Name { get; set; }
        public string Description;
        public string Type;

        public Dog()
        {
            Name = string.Empty;
            Type = string.Empty;
            Description = string.Empty;
        }
        public Dog(string name, string description, string type)
        {
            Name = name;
            Description = description;
            Type = type;
        }
        public override string Describe()
        {
            return $"[ ! ] Data Display [ ! ]\n" +
                $"{Name}\n" +
                $"{Description}\n" +
                $"{Type}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dogOne = new Dog();
            Dog dogTwo = new Dog("dogNAME", "dogDESCRIPTION", "dogTYPE");
            Console.WriteLine(dogOne.Describe());
            Console.WriteLine(dogTwo.Describe());
        }
    }
}