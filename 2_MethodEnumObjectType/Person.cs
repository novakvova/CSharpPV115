using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_MethodEnumObjectType
{
    public class Person : IDisposable
    {
        public Person()
        {
            _counter++;
        }
        private static int _counter = 0;
        public string Name { get; set; }
        public int Age { get; set; }
        public PersonType PersonType { get; set; }

        public void Dispose()
        {
            Console.WriteLine("Delete object");
        }

        public override string ToString()
        {
            return $"{this.Name} {Age} [{PersonType}]";
        }

        public static int? UpdatePerson(Person p, int i = 0)
        {
            p.Name = "No name";
            return null;
            //return 0;
        }
        public static int GetCounter { get { return _counter; } }
    }
}
