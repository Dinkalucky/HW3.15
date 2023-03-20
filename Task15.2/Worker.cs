using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15._2
{
    public struct Worker
    {
        private string name;
        private string jobTitle;
        private int year;

        private Worker[] workersArray;

        public void WorkersArray()
        {
            workersArray = new Worker[5];

            for (int i = 0; i < workersArray.Length; i++)
            {
                Console.WriteLine($"Введіть ім'я {i + 1} працівника");
                workersArray[i].name = Console.ReadLine();

                Console.WriteLine($"Введіть посаду {i + 1} працівника");
                workersArray[i].jobTitle = Console.ReadLine();
                try
                {
                    Console.WriteLine($"Введіть рік початку роботи {i + 1} працівника");
                    workersArray[i].year = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Невірний формат вводу");
                    Console.WriteLine($"Введіть рік початку роботи {i + 1} працівника");
                    workersArray[i].year = Int32.Parse(Console.ReadLine());
                }
                
            }
        }

        public void ShowArray()
        {
            var sortedArray = workersArray.OrderBy(x => x.name).ToArray();
            foreach (var worker in sortedArray)
            {
                Console.Write(worker.name + "-" + worker.jobTitle + "-" + worker.year + "\n");
            }
        }

        public void TheOldestWorker(int stazh)
        {
            string theOldestWorkerName = workersArray.Where(y => DateTime.Now.Year - y.year > stazh).Select(n=>n.name).First();
            Console.WriteLine($"{theOldestWorkerName} працює довше {stazh} років?");
        }
    }
}
