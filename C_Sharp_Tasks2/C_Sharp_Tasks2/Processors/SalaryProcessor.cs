using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks2
{
    class SalaryProcessor: PersonsProcessor
    {
        public override void Process(IEnumerable<Person> persons)
        {
            IEnumerator<Person> person = persons.GetEnumerator();
            person.MoveNext();
            Person highlyPaid = person.Current;

            while (person.MoveNext())
            {
                if (person.Current.GetAge >= 18)
                {
                    Console.WriteLine(person.Current.GetFullName + " " + person.Current.GetAge + " " + person.Current.OverallEarnings);
                    if (highlyPaid.OverallEarnings < person.Current.OverallEarnings) highlyPaid = person.Current;
                }
            }
            Console.WriteLine("Highly payed person");
            Console.WriteLine(highlyPaid.GetFullName + " " + highlyPaid.GetAge + " " + highlyPaid.OverallEarnings);
        }

    }
}
