using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSDL_IDM_P2.Pages
{
    public class People : List<Person>
    {
        public People()
        {
            Add(new Person("Tom", false));
            Add(new Person("Jen", false));
        }
    }
}
