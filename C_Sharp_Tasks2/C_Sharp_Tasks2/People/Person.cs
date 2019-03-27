using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks2
{
    public class Person
    {
        public DateTime _BirthDate { get; set; }
        public string _FirstName { get; set; }
        public string _LastName { get; set; }
        public virtual decimal _HourRate { get; set; }

        public Person() { }

        public Person(string FirstName, string LastName, DateTime BirthDate, decimal HourRate) {

            _FirstName = FirstName;
            _LastName = LastName;
            _BirthDate = BirthDate;
            _HourRate = HourRate;
        }

        public int GetAge {
            get
            {
                //int age = 0;
                //age = DateTime.Now.Year - _BirthDate.Year;
                //if (DateTime.Now.DayOfYear < _BirthDate.DayOfYear)
                    //age = age - 1;
                //return age;
                return DateTime.Now.Year - _BirthDate.Year;
            }

        }

        public string GetFullName {
            get {
                return _FirstName + " " + _LastName;
            }
        }

        public string GetSalary(){

            var salary = _HourRate * 160;
            var age = GetAge;
            if (age < 18) { return "It's child"; }
            else { return salary.ToString(); }

        }

        public string GetPersonInfo() {
            var fullName = GetFullName;
            string salary = GetSalary();            
            var age = GetAge;

            string info = fullName + " " + age + " " + salary;
            return info;

        }

        public decimal OverallEarnings
        {
            get
            {
                int months = (DateTime.Today.Year * 12 + DateTime.Today.Month) - (_BirthDate.AddYears(18).Year * 12 + _BirthDate.AddYears(18).Month);
                return months * 160 * _HourRate;
            }
        }
    }
}

