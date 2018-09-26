using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSDL_IDM_P2.Pages
{
    public class Person
    {
        public Person(string name, bool likeCar)
        {
            Name = name;
            LikeCar = likeCar;
        }
        public string Name { set; get; }
        public bool LikeCar { set; get; }
    }
}
