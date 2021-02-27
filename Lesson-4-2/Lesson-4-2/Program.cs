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
            Console.WriteLine("Введите последовательность целых чисел через пробел, чтобы вывести сумму");
            string nomber = Console.ReadLine();//Строка с пробелами
            Console.WriteLine(SumStr(nomber));
        }
        static int SumStr(string nomber)
        {
            int sum = 0;
            string[] nmb = nomber.Split(' ');//разбиваем строку на массив строк
            int[] arr = new int[nmb.Length];//Создаем массив инт
            //Преобразуем стринг в инт и суммируем значения
            for (int i = 0; i < nmb.Length; i++)
            {
                arr[i] = Convert.ToInt32(nmb[i]);
                sum += arr[i];
            }
            return sum;//Возвращаем сумму
        }

    }
}
