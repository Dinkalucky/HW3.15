using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task9._2.Program;

namespace Task9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Calculator calculator = new Calculator();
            int x, y;
            string dia;

            while (true)
            {
                try
                {
                    Console.WriteLine("Введіть перше число: ");
                    x = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Введіть друге число: ");
                    y = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Яку дію над числами ви хотіли б виконати?");
                    dia = Console.ReadLine();


                    switch (dia)
                    {
                        case "Add":
                            calculator.Add(x, y);
                            break;
                        case "Sub":
                            calculator.Sub(x, y);
                            break;
                        case "Mul":
                            calculator.Mul(x, y);
                            break;
                        case "Div":
                            calculator.Div(x, y);
                            break;
                        default: throw new Exception("Такої дії немає");
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Неправильно ввели число");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

        }
    }
}
