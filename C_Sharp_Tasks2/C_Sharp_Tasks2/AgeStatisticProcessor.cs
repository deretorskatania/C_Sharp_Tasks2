using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks2
{
    class AgeStatisticProcessor:PersonsProcessor
    {
        public override void Process(IEnumerable<Person> persons)
        {
            IEnumerator<Person> person = persons.GetEnumerator();
            int averageAge = 0;
            var youngestPerson = persons.First();
            var oldestPerson = persons.First();

            while (person.MoveNext())
            {
                averageAge += person.Current.GetAge;
                if (youngestPerson.GetAge > person.Current.GetAge)
                    youngestPerson = person.Current;
                else if (oldestPerson.GetAge < person.Current.GetAge)
                    oldestPerson = person.Current;                
            }
            Console.WriteLine("Average Age = " + averageAge / persons.Count() + "\nYoungest Person: " +  youngestPerson.GetFullName + "\nOldest Person: " + oldestPerson.GetFullName);
            
        }
    }
}
