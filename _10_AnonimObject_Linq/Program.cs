using Bogus;
using System.Security.Cryptography.X509Certificates;
using static Bogus.DataSets.Name;

namespace _10_AnonimObject_Linq
{
    class Program
    {
        //unsafe struct Node
        //{
        //    public int Value;
        //    public Node* Left;
        //    public Node* Right;
        //}

        public static void Main(string[] args)
        {
            //var myUser = new
            //{
            //    Name="Іван",
            //    Age=20,
            //};
            //Console.WriteLine(myUser.GetType().Name);
            //Console.WriteLine(myUser.GetType().BaseType);
            //Console.WriteLine(myUser.ToString());
            //Console.WriteLine(GetNewObject());
            //Console.WriteLine(sizeof(int)); 
            //Console.WriteLine(sizeof(float)); 
            //Console.WriteLine(sizeof(double)); 
            //Console.WriteLine(sizeof(decimal)); 

            //int [] mylist = { 2, 4, 1, 3, -4, 3, -8, -5 };
            //var items = mylist.Where(x=>x<0);
            //var items = from i in mylist where i < 0 select i;
            //foreach (var item in items)
            //{
            //    Console.WriteLine(item);
            //}
            //
            //mylist = mylist.OrderByDescending(x => x).ToArray();
            //foreach (var item in mylist)
            //    Console.Write("{0}\t",item);

            var userIds = 0;
            var testUsers = new Faker<User>("uk")
                //Optional: Call for objects that have complex initialization
                .CustomInstantiator(f => new User(userIds++, f.Random.Replace("###-##-####")))
                //Use an enum outside scope.
                .RuleFor(u => u.Gender, f => f.PickRandom<Gender>())
                //Basic rules using built-in generators
                .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName(u.Gender))
                .RuleFor(u => u.LastName, (f, u) => f.Name.LastName(u.Gender))
                .RuleFor(u => u.Avatar, f => f.Internet.Avatar())
                .RuleFor(u => u.UserName, (f, u) => f.Internet.UserName(u.FirstName, u.LastName))
                .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
                .RuleFor(u => u.SomethingUnique, f => $"Value {f.UniqueIndex}")
                //Use a method outside scope.
                .RuleFor(u => u.CartId, f => Guid.NewGuid())
                //Compound property with context, use the first/last name properties
                .RuleFor(u => u.FullName, (f, u) => u.FirstName + " " + u.LastName)
                //Optional: After all rules are applied finish with the following action
                .FinishWith((f, u) =>
                {
                    Console.WriteLine("User Created! Id={0}", u.Id);
                });

            List<User> users = new List<User>(); 
            for (int i = 0; i < 10; i++)
            {
                var user = testUsers.Generate();
                users.Add(user);
                //Console.WriteLine(user);
            }

            var meta = users.Where(x => x.Email.EndsWith("meta.ua"));
            foreach (var user in meta)
            {
                Console.WriteLine(user);
            }

        }
        public static object GetNewObject()
        {
            return new { Girl="Мальвіна", Age=25, Color="Black" };
        }
    }
}

