using System.Runtime.InteropServices;

namespace _11_GB
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("_____GC Basic_____");
            Console.WriteLine("Кільлькість байт виділених для кучі: {0}",
                GC.GetTotalMemory(false));
            Console.WriteLine("Кількість згенерованих обєктів в ОС: {0}",
               GC.MaxGeneration);
            string str = "Hello";
            using (Car audi = new Car("Audi A4", 50))
            {
                Console.WriteLine(audi);
                Console.WriteLine("Create new object");
                Console.WriteLine("Покоління обєкта в кучі audi: {0}",
                    GC.GetGeneration(audi));
            }
            GC.Collect();

            Car reno = new Car("Honda Civic", 50);         

            Console.WriteLine("Покоління обєкта в кучі reno: {0}",
                GC.GetGeneration(reno));

            Console.WriteLine("Адреса памяті audi: {0}", Get(reno));

            Console.WriteLine("Кільлькість байт виділених для кучі: {0}", 
                GC.GetTotalMemory(false));
        }

        static void MakeCar()
        {
            Car car = new Car();
            car = null;
        }

        public static string Get(object a)
        {
            ref object r = ref a;
            //roughly equivalent to
            TypedReference tr = __makeref(a);
            Console.WriteLine(&a);
            return tr.GetHashCode().ToString();
            //Console.WriteLine("tr {0}", tr.GetHashCode());
            //GCHandle objHandle = GCHandle.Alloc(a, GCHandleType.WeakTrackResurrection);
            
            //IntPtr pObj = objHandle.AddrOfPinnedObject();
            //return pObj.ToString();
        }
    }
}

