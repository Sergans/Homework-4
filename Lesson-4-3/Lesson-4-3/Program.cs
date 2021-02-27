using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_3
{
    class Program
    {
        enum Season
        {
            Winter = 1, Spring, Summer, Autumn//Присвоено "1" чтобы не путаться
        }
        static void Main(string[] args)
        {
            int month;
            do
            {

                Console.WriteLine("Введите порядковый номер месяца");
                month = Convert.ToInt32(Console.ReadLine());
                if (month > 12 || month < 0)
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                }

            } while (month > 12 || month < 0);
            //Основной блок с методами
            Console.WriteLine((SeasonPeriodRus(SeasonPeriod(month))));

        }
        //Метод 1
        static int SeasonPeriod(int month)
        {
            int a = 0;
            if (month == 1 || month == 2 || month == 12)
            {
                a = ((int)Season.Winter);

            }
            else if (month == 3 || month == 4 || month == 5)
            {
                a = ((int)Season.Spring);
            }
            else if (month == 6 || month == 7 || month == 8)
            {
                a = ((int)Season.Summer);
            }
            else if (month == 9 || month == 10 || month == 11)
            {
                a = ((int)Season.Autumn);
            }
            return a;

        }
        //Метод 2, без второго перечисления
        static string SeasonPeriodRus(int SeasonPeriod)
        {
            string a = "";
            if (SeasonPeriod == 1)
            {
                a = "Зима";
            }
            else if (SeasonPeriod == 2)
            {
                a = "Весна";
            }
            else if (SeasonPeriod == 3)
            {
                a = "Лето";
            }
            else if (SeasonPeriod == 4)
            {
                a = "Осень";
            }
            return a;
        }
    }
}
