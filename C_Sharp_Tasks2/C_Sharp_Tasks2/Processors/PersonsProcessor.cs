using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tasks2
{
    public abstract class PersonsProcessor
    {
        public abstract void Process(IEnumerable<Person> persons);
    }
}
