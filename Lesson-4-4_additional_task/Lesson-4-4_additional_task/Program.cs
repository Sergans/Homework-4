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
            
            Console.WriteLine("Введите значение последовательности Фибонначи,чтобы получить число");
            int n = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Число из последовательности:{Fibbo(n)}");
        }
        static int Fibbo(int n)
        {
            if (n == 0)
            {
                n = 0;
                return n;
            }
            else if (n == 1)
            {
                n = 1;
                return n;
            }
            return n = Fibbo(n - 1) + Fibbo(n - 2);

        }
    }
}
