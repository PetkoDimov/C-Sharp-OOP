using System;

namespace Animals
{
    public class StartUp
    {
        static void Main(string[] args)
        {



            while (true)
            {
                string inputClass = Console.ReadLine();
                if (inputClass == "Beast!")
                {
                    break;
                }
                string[] input = Console.ReadLine().Split(" ");
                var name = input[0];
                var age = int.Parse(input[1]);
                var gender = input[2];

                if (age < 0 || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(gender))
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                if (inputClass == "Cat")
                {
                    Cat cat = new Cat(name, age, gender);
                    Console.WriteLine(cat);
                    Console.WriteLine(cat.ProduceSound());
                }
                else if (inputClass == "Dog")
                {
                    Dog dog = new Dog(name, age, gender);
                    Console.WriteLine(dog);
                    Console.WriteLine(dog.ProduceSound());
                }
                else if (inputClass == "Frog")
                {
                    Frog frog = new Frog(name, age, gender);
                    Console.WriteLine(frog);
                    Console.WriteLine(frog.ProduceSound());
                }
                else if (inputClass == "Kitten")
                {
                    Kitten kitten = new Kitten(name, age);
                    Console.WriteLine(kitten);
                    Console.WriteLine(kitten.ProduceSound());
                }
                else if (inputClass == "Tomcat")
                {
                    Tomcat tomcat = new Tomcat(name, age);
                    Console.WriteLine(tomcat);
                    Console.WriteLine(tomcat.ProduceSound());
                }

            }
        }
    }
}
