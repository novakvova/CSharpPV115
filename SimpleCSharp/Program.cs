using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace SimpleCSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            StringBuilder name = new StringBuilder("Маргарита");
            name.Replace('М', 'Х');
            Console.WriteLine(name);
            //string newName = name.ToLower();
            //Console.WriteLine(newName);
            //string path = @"c:\232.txt";
            var dateNow = DateTime.Now;
            CultureInfo local = new CultureInfo("pl");//new CultureInfo("uk-UA");//new CultureInfo("en-US");
            Console.WriteLine("Run program: {0}", dateNow.ToString("dd MMMM yyyy HH:mm:ss", local));

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(200);
            }
            
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);


        }
    }
}

