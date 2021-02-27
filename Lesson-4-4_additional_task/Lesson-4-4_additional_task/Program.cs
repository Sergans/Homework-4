using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_4_additional_task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Набросок
            Console.WriteLine("Введите значение");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] f = new int[n];

            Console.WriteLine(Fibbo(n));
        }
    }
}
