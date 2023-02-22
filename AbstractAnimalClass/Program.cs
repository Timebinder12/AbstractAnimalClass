using System;

namespace Animals
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
    class Program
    {
        class Wolf : Animal
        {

            public override string Name { get; set; }
            public string Type { get; set; }
            public string Food { get; set; }

            public Wolf()
              
            {
                Name = string.Empty;
                Type = string.Empty;
                Food = string.Empty;
            }
            public Wolf(string name, string type, string food)
            {
                Name = name;
                Type = type;
                Food = food;
            }
            public override string Describe()
            {
                return "I am a " + Type + " and I am a " + Food + ". My name is " + Name; 
            }
        }

        static void Main(string[] args)
        {
            Wolf wolf1 = new Wolf("Big bad wolf", "Wolf", "Carnivore");
            Console.WriteLine(wolf1.Describe());

            Wolf wolf2 = new Wolf();
            wolf2.Name = "Beowulf";
            wolf2.Type = "Wolf";
            wolf2.Food = "Carnivore";
            Console.WriteLine(wolf2.Describe());
        }
    }
}
