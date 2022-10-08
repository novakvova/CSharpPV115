using System.Collections;

namespace _7_Collection
{
    class Program
    {
        public static void Main(string[] args)
        {
            //c++ Vector
            ///ArrayList mas = new ArrayList();
            ///mas.Add(23);
            ///mas.Add("Привіт");
            ///mas.Add(true);
            ///mas[0] = "Сало";
            ///foreach (var item in mas)
            ///{
            ///    Console.WriteLine(item);
            ///}

            ///Hashtable ht = new Hashtable();
            ///ht.Add("Яблуко", "Apple");
            ///ht.Add("Стіл", "Table");
            ///ht.Add("Дічина", "Girl");
            ///ht.Add("Жінка", "Woman");
            ///ht.Add("Дружина", "Wife");
            ///foreach (string s in ht.Keys)
            ///{
            ///    Console.WriteLine($"{s}\t{ht[s]}");
            ///}

            ///SortedList ht = new SortedList();
            ///ht.Add("Яблуко", "Apple");
            ///ht.Add("Стіл", "Table");
            ///ht.Add("Дічина", "Girl");
            ///ht.Add("Жінка", "Woman");
            ///ht.Add("Дружина", "Wife");
            ///foreach (string s in ht.Keys)
            ///{
            ///    Console.WriteLine($"{s}\t{ht[s]}");
            ///}

            //List<Girl> ints = new List<Girl>();
            //ints.Add(new Girl("Галя", 25, "+38 097 34 33 223"));
            //ints.Add(new Girl("Оксана", 18, "+38 098 34 33 223"));
            //ints.Add(new Girl("Марина", 32, "+38 063 34 33 223"));
            //ints.Add(new Girl("Настя", 41, "+38 098 34 33 223"));
            //ints.Sort();
            ////foreach (Girl g in ints)
            ////    Console.WriteLine(g);

            //int index = ints.BinarySearch(new Girl("", 18, ""));
            ////Console.WriteLine(index);
            //if(index>=0)
            //    Console.WriteLine(ints[index]);

            HashSet<string> spisok = new HashSet<string>()
        {
            "Николай",
            "Дмитрий",
            "Highload_Today",
            "Валерий",
            "Сергей",
            "Highload_Today",
            "Сергей"
        };
            
            foreach (var item in spisok)
            {
                Console.WriteLine(item);
            }
        }
    }
}

