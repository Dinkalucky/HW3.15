using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            Console.OutputEncoding = Encoding.UTF8;
            int stazh;

            worker.WorkersArray();
            worker.ShowArray();

            Console.WriteLine("Хто працює довше ... років?");
            Int32.TryParse(Console.ReadLine(), out stazh);
            worker.TheOldestWorker(stazh);

            Console.ReadLine();
        }
    }
}
