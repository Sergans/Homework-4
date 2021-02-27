using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вариант программы на 3 последовательности
            string[] chel = new string[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Введите данные по инструкции: Имя,Фамилию,Отчество. Вы ввели {i}-(Всего 3)");
                Console.WriteLine("Введите имя");
                string ferstName = Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                string lastName = Console.ReadLine();
                Console.WriteLine("Введите отчество");
                string patronymic = Console.ReadLine();
                chel[i] = GetFullName(ferstName, lastName, patronymic);
                Console.Clear();
            }
            Console.Clear();
            Console.WriteLine("Выводим список ФИО");
            foreach (string sps in chel)
            {
                Console.WriteLine($"ФИО:{sps}");
            }

        }
        //метод
        static string GetFullName(string ferstName, string lastName, string patronymic)
        {
            string a = ($"{lastName} {ferstName} {patronymic}");
            return a;
        }
    }
}
