using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks2
{
    class NamesProcessor : PersonsProcessor
    {
        public override void Process(IEnumerable<Person> persons)
        {
            IEnumerator<Person> person = persons.GetEnumerator();
            SortedList<string,int> names = new SortedList<string ,int>();
            person.MoveNext();

            int count = 0;

            while (person.MoveNext())
            {
                if (names.ContainsKey(person.Current._FirstName))               
                    names[person.Current._FirstName]++;                
                else                
                    names.Add(person.Current._FirstName, 1);                
                count++;
            }
            foreach (KeyValuePair<string, int> item in names)
            {
                Console.WriteLine(item.Key + " is used " + 100 * item.Value / count + "%");
            }


        }
    }
}
