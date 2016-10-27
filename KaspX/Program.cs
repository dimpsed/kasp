using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KaspX
{
    class Program
    {
        static void Main(string[] args)
        {

            var timer = new Stopwatch();
            var mass = new List<int>();
            var x = 50;
            //Заполнение коллекции числами
            for (var i = 1; i < 50; i++)
            {
                mass.Add(i);
            }

            Run(mass, x);

            Console.ReadLine();
        }
         

        public static void Run(List<int> mass, int x)
        {
            var numDict = new Dictionary<int, int>();
            var result = 0;
            foreach (var num in mass)
            {
                if (!numDict.ContainsKey(num) && !numDict.ContainsKey(Math.Abs(x - num)))
                {
                    numDict.Add(Math.Abs(x - num), num);
                }
            }

            foreach (var num in mass.Distinct())
            {
                if (numDict.ContainsKey(num) && numDict[num] + num == x)
                {
                    Console.WriteLine("{0}+{1} = {2}", num, numDict[num], x);
                    result++;
                }
            }

            Console.WriteLine("Всего элементов {0}", result);
        }

    }

}
