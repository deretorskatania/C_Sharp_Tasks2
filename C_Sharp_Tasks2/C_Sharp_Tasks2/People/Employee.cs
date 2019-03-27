using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks2
{
    public class Employee: Person
    {
        public Employee(string FirstName, string LastName, DateTime BirthDate, decimal HourRate)
        {

            _FirstName = FirstName;
            _LastName = LastName;
            _BirthDate = BirthDate;
            _HourRate = HourRate;
        }
        public override decimal _HourRate
        {
            get => base._HourRate * (decimal)1.1; 
        }


    }
}
