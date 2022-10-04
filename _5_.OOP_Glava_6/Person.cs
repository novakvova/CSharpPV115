using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_.OOP_Glava_6
{
    public abstract class Person
    {
        protected string _name;
        public Person()
        {

        }
        public Person(string name)
        {
            _name = name;
        }

        public abstract void Show();
    }
}
