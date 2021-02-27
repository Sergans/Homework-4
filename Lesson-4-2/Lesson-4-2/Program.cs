using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Набросок
            Console.WriteLine("Введите последовательность целых чисел через пробел чтобы вывести сумму");
            string nomber = Console.ReadLine();//Строка с пробелами
            Console.WriteLine(SumStr(nomber));
        }

    }
}
