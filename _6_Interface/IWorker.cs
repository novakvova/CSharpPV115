using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Interface
{
    abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public interface Asistant
    {
        void PrintDocument();
    }
    public interface ICleaner
    {
        int UseWater { get; set; }
        int Speed { get; set; }
        void Clean();
    }
    class Worker : Person, Asistant, ICleaner
    {
        public int Speed { get; set; }
        public int UseWater { get; set; }

        public void Clean()
        {
            Console.WriteLine("Швикдість прибирання {0}. Розхід води {1}", Speed, UseWater);
        }

        public void PrintDocument()
        {
            Console.WriteLine("Друк документу");
        }
    }
    public interface IWorker
    {
    }
}
