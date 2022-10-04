using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_.OOP_Glava_6
{
    public class Worker : Person
    {
        private string _profession;
        public Worker() : base("noname")
        {

        }
        public Worker(string name, string profession) : base(name)
        {
            _profession = profession;
        }

        public override void Show()
        {
            Console.WriteLine(this._name+"\t"+this._profession);
        }
    }
}
