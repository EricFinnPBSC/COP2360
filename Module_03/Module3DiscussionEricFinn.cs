using System;

namespace Module3Discussion
{
    public class Panda
    {
        private string name;
        private string favoriteFood;

        public Panda(string n, string food)
        {
            name = n;
            favoriteFood = food;
        }

        public override string ToString() => $"{name} loves {favoriteFood}";
    }

    public static class Program
    {
        public static void Main()
        {
            Panda panda1 = new Panda("Eric", "Bamboo");
            object obj1 = panda1;
            Console.WriteLine(obj1);

            Panda panda2 = new Panda("Finn", "Apples");
            object obj2 = panda2;
            Console.WriteLine(obj2);
        }
    }
}