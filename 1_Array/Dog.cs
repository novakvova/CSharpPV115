using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Array
{
    class DogComparer : System.Collections.IComparer
    {
        public int Compare(object x, object y)
        {
            return ((Dog)x).Breed.CompareTo(((Dog)y).Breed);
        }
    }
    public class Dog //: IComparable
    {
        public string Name { get; set; }
        public string Breed { get; set; }

        //public int CompareTo(object? obj)
        //{
        //    return Name.CompareTo(((Dog)obj).Name);
        //}

        public override string ToString()
        {
            return $"{Name} - {Breed}";
        }
    }
}
