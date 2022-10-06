
using _6_Interface;

namespace _6_interface
{

    class Program
    {
        public static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Робота з інтерфейсами!");
            //Person pelip = new Worker();
            //if(pelip is Asistant asistant)
            //    ShowInfoAsistant(asistant);
            //Person ivan = new Worker();
            //if(ivan is ICleaner cleaner)
            //{
            //    cleaner.Speed = 10;
            //    cleaner.UseWater = 20;
            //    cleaner.Clean();
            //}

            //ICleaner[] cleaners = new ICleaner[10];
            //cleaners[0] = new Worker();



            //Nurse[] list = new Nurse[3];
            //list[0] = new Nurse
            //{
            //    Name = "Василь Петрович",
            //    Kind = Kind.HoneyBrother,
            //    Experience = 10
            //};
            //list[1] = new Nurse
            //{
            //    Name = "Василь Петрович",
            //    Kind = Kind.Older,
            //    Experience = 15
            //};
            //list[2] = new Nurse
            //{
            //    Name = "Антошка Вікуся Малько",
            //    Kind = Kind.Midwife,
            //    Experience = 25
            //};

            //Array.Sort(list);
            //Array.Reverse(list);

            //foreach (Nurse n in list)
            //{
            //    Console.WriteLine(n);
            //}


            Nurse ivanka = new Nurse
            {
                Name = "Іванка Петрівна",
                Experience = 14,
                Kind = Kind.Midwife
            };
            
            Nurse maryna = (Nurse)ivanka.Clone();
            maryna.Name = "Марина";

            Console.WriteLine(ivanka);
            Console.WriteLine(maryna);
        }

        public static void ShowInfoAsistant(Asistant asistant)
        {
            Console.WriteLine("Даємо роботу асистенту");
            asistant.PrintDocument();
        }
    }
}

