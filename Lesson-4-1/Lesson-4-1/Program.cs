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

        }
        //метод
        static string GetFullName(string ferstName, string lastName, string patronymic)
        {
            string a = ($"{lastName} {ferstName} {patronymic}");
            return a;
        }
    }
}
