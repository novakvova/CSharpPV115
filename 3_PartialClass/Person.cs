using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PartialClass
{
    public delegate void PersonInfoDelegate(string text);
    public partial class Person
    {
        public PersonInfoDelegate PersonInfoDelegate;
        public event PersonInfoDelegate OnPersonInfo;
        private string _id;
        private string _name;
    }
}
