using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9._2
{
    public class Calculator
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"{a}+{b} = {a+b}");
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine($"{a}-{b} = {a - b}");
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine($"{a}*{b} = {a * b}");
        }
        public void Div(int a, int b)
        {
            if (b==0)
            {
                throw new Exception("Спроба ділення на нуль");
            }
            Console.WriteLine($"{a}/{b} = {a / b}");
        }
    }
}
