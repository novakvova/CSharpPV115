using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PartialClass
{
    public partial class Person
    {
        public Person(string id, string name)
        {
            _id = id;
            _name = name;   
        }

        public override string ToString()
        {
            if (OnPersonInfo != null)
                OnPersonInfo("Ще івент!!!");
            if (PersonInfoDelegate != null)
                PersonInfoDelegate("Треба іти копати бурштин, якраз добра погода");
            return $"{_id}\t{_name}";
        }
    }
}
