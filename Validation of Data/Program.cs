using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int lines = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                string[] command = Console.ReadLine().Split(" ");
                Person person = new Person(command[0], command[1], int.Parse(command[2]), decimal.Parse(command[3]));
                persons.Add(person);

            }

            decimal percentge = decimal.Parse(Console.ReadLine());

            foreach (var item in persons)
            {
                item.IncreaseSalary(percentge);
            }
            foreach (var item in persons)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
