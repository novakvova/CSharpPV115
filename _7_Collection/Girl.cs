using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Collection
{
    public class Girl : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }

        public Girl()
        {

        }
        public Girl(string name, int age, string phone)
        {
            Name = name;
            Age = age;
            Phone = phone;
        }

        public override string ToString()
        {
            return $"{Name}\t{Age}\t{Phone}";
        }

        public int CompareTo(object? obj)
        {
            if(obj is Girl girl)
                return girl.Age.CompareTo(this.Age);
            return 1;
        }
    }
}
