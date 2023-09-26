using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.CherepanovVS.Sprint1.V0.Lib;

namespace Tyuiu.CherepanovVS.Sprint1.Task0.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Черепанов В.С. | ПКТб-23-1";
            Console.WriteLine("##############################################################################");
            Console.WriteLine("*Спринт1                                                                     *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                           *");
            Console.WriteLine("*Задание #0                                                                  *");
            Console.WriteLine("*Вариант #0                                                                  *");
            Console.WriteLine("*Выполнил: Черепанов Вячеслав Сергеевич| ПКТб-23-1                           *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                    *");
            Console.WriteLine("*Написать программу, которая вычисляет выражение 6/2/3+1-6/2*3               *");
            Console.WriteLine("*и печатает результат на экране.                                             *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* 6/2/3+1-6/2*3                                                              *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");
            double x=1;
            double y=5;
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();
        }

    }
}
