using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_GB
{
    public class Car :IDisposable
    {
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }
        public Car()
        {

        }
        public Car(string name, int speed)
        {
            PetName = name;
            CurrentSpeed = speed;
        }
        public override string ToString()
        {
            return $"{PetName} is going {CurrentSpeed} MPH";
        }

        public void Dispose()
        {
            Console.WriteLine("Обєект буде видалено");
        }
    }
}
