using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace C_Sharp_Tasks2
{
    class PersonsGenerator
    {

        public string GetRandomFirstName() {
            string[] firstNames = new string[] { "Liam", "William", "James", "Michael", "Alexander", "Daniel", "Matthew", "Jackson", "David", "Joseph", "Henry", "Sebastian", "John", "Luke", "Anthony" };
            Random r = new Random();
            int idx = r.Next(0, firstNames.Length - 1);
            return firstNames[idx];
        }

        public string GetRandomLastName()
        {
            string[] lastNames = new string[] { "Abbott", "Acosta", "Adams", "Adkins", "Aguilar" };
            Random r = new Random();
            int idx = r.Next(0, lastNames.Length - 1);
            return lastNames[idx];
        }

        public DateTime GetRandomDateOfBirth() {

            DateTime date1 = new DateTime(1950, 1, 1);
            DateTime date2 = new DateTime(2019, 12, 31);
            return Task1.GetRandomDate(date1, date2);

        }

        public decimal GetRandomHourRate() {
            double min = 0;
            double max = 100;

            Random r = new Random();
            var next = r.NextDouble();
            var res = min + (next * (max - min));
            return (decimal)res;
        }

        public Person [] Generate(int amount)
        {
            List<Person> persons = new List<Person> { };
            Random r = new Random();

            for (int i = 0; i < amount; i++)
            {
                var idx = r.Next(0, 3);
                DateTime randomBirthDate = GetRandomDateOfBirth();
                string randomFirstName = GetRandomFirstName();
                string randomLastName = GetRandomLastName();
                decimal randomHourRate = GetRandomHourRate();
                
                
                    switch (idx)
                    {
                        case 0:
                            persons.Add(new Employee(randomFirstName, randomLastName, randomBirthDate, randomHourRate));
                            break;
                        case 1:
                            persons.Add(new Freelancer(randomFirstName, randomLastName, randomBirthDate, randomHourRate));
                            break;
                        case 2:
                            persons.Add(new Subcontractor(randomFirstName, randomLastName, randomBirthDate, randomHourRate));
                            break;

                    }
                    Thread.Sleep(100);
                    /*Person person = new Person
                    {
                        _FirstName = GetRandomFirstName(),
                        _LastName = GetRandomLastName(),
                        _BirthDate = GetRandomDateOfBirth(),
                        _HourRate = GetRandomHourRate()
                    };
                    persons[i]=person;
                    Thread.Sleep(100);*/
                
            }
            return persons.ToArray();

        }



    }
}
