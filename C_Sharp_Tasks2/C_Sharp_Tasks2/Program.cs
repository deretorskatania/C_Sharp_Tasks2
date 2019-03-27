using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks2
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonsGenerator personsGenerator = new PersonsGenerator();
            Person[] persons = personsGenerator.Generate(50);
            foreach (var  result in persons)
            {
                Console.WriteLine(result.GetPersonInfo());
            }

            Console.WriteLine("\nSalaryProcessor");
            new SalaryProcessor().Process(persons);

            Console.WriteLine("\nAgeStatisticProcessor");
            new AgeStatisticProcessor().Process(persons);

            Console.WriteLine("\nNamesProcessor");
            new NamesProcessor().Process(persons);
            Console.WriteLine("\n");

            foreach (Person person in persons)
            {
                Console.WriteLine(person.GetFullName + ": " + person.GetType().Name);
            }
            Console.ReadKey();
        }
    }
}
