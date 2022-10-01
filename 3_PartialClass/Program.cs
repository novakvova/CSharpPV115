
namespace _3_PartialClass
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person p = new Person("23f", "Василь Петрович");
            p.PersonInfoDelegate = PersonInfo;
            p.OnPersonInfo += PersonInfo;
            p.OnPersonInfo += P_OnPersonInfo; ;
            Console.WriteLine(p);
        }

        private static void P_OnPersonInfo(string text)
        {
            Console.WriteLine("Метод номер 2"); ;
        }

        public static void PersonInfo(string data)
        {
            Console.WriteLine("Цей код в прогармі");
            Console.WriteLine(data);
        }
    }
}
