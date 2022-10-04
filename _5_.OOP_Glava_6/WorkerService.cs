using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_.OOP_Glava_6
{
    public class WorkerService
    {
        Worker[] wokers = new Worker[1000];
        int count = 0;

        public void Add(Worker w)
        {
            wokers[count++] = w;
        }

        // Indexer declaration
        public Worker this[int index]
        {
            get {
                if (index >= count)
                    throw new Exception("Куди лізеш :)");
                return wokers[index];
            }
        }
    }
}
