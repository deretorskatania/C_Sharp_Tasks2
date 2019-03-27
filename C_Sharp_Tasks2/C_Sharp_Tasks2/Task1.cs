using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks2
{
    class Task1
    {
        static Random rand = new Random();

        public static DateTime GetRandomDate(DateTime minDate, DateTime maxDate)
        {
            int cdayRange = (maxDate - minDate).Days;
            return minDate.AddDays(rand.NextDouble() * cdayRange);
        }
    }
}
