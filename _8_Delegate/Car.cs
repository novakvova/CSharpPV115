using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Delegate
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string PetName { get; set; }

        private bool carIsDead;

        public Car()
        {

        }
        public Car(string name, int maxSp, int currentSpeed)
        {
            CurrentSpeed = currentSpeed;
            MaxSpeed = maxSp;
            PetName = name;
        }

        public delegate void CarEngineHandler(string msgForCaller);
        //private CarEngineHandler listOfHandler;
        public event CarEngineHandler errorMessageEvent;
        //public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        //{
        //    listOfHandler += methodToCall;
        //}

        //public void UnRegisterWithCarEngine(CarEngineHandler methodToCall)
        //{
        //    listOfHandler -= methodToCall;
        //}

        public void Accelerate(int delta)
        {
            if(carIsDead)
            {
                if (errorMessageEvent != null)
                    errorMessageEvent("Вибач, авто поломаний...");
            }
            else
            {
                CurrentSpeed +=delta;
                if(10==(MaxSpeed-CurrentSpeed) && errorMessageEvent != null)
                {
                    errorMessageEvent("Ви наближаєтеся до критичної швидоксті");
                }
                if(CurrentSpeed>=MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("Поточна швикдість авто = {0}", CurrentSpeed);
            }
        }
    }
}
