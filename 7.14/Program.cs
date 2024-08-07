namespace _7._14
{
    public interface IDisplay
    {
        string Name { get; set; }

    }

    public class Dog : IDisplay
    {
          public string Name { get; set; }

        public Dog(string name)
        {
            Name = name;
        }

      

        public void Display()
        {
            Console.WriteLine($"Dog's Name: {Name}");
        }
    }

    public class Cat : IDisplay
    {
        public string Name { get; set; }

        public Cat(string name)
        {
            Name = name;
        }

        public void Display() {
            Console.WriteLine($"Cat's Name : {Name}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Jonh");
            Cat cat = new Cat("Meo");

            dog.Display();
            cat.Display();
        }
    }
}
