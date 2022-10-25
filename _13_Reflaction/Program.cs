using System.Reflection;
using System.Runtime.ExceptionServices;

namespace _13_Reflaction
{
    class Program
    {
        public static void Main(string[] args)
        {
            //var assembly = Assembly.GetExecutingAssembly();
            // See https://aka.ms/new-console-template for more information
            //Console.WriteLine(assembly.GetName());

            try
            {
                Type type = Type.GetType("_12_1_SendMessage.Message,_12_1_SendMessage");
                Console.WriteLine(type.Name);
                ShowInfoType(type);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }

        public static void ShowInfoType(Type type)
        {
            Console.WriteLine("Show info type: {0}"+type.Name);
            foreach(var methodInfo in type.GetMethods())
            {
                Console.WriteLine("Show methods {0}", methodInfo.Name);
            }
        }

    }
}

