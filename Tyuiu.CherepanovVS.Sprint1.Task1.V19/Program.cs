using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.CherepanovVS.Sprint1.Task1.V19.Lib;

namespace Tyuiu.CherepanovVS.Sprint1.Task1.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService1 ret = new DataService1();

            Console.Title = "Спринт #1 | Выполнил: Черепанов В.С. | ПКТб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт1                                                                   *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                         *");
            Console.WriteLine("*Задание #1                                                                *");
            Console.WriteLine("*Вариант #19                                                               *");
            Console.WriteLine("*Выполнил: Черепанов Вячеслав Сергеевич| ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные,   *");
            Console.WriteLine("*вычисляет результат по формуле (1+3*x)/(4*y) и печатает его на экране.    *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            double x, y;
            Console.WriteLine("Введите значение переменной х");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной y");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine(ret.Calculate(x,y));
            Console.ReadLine();
        }
    }
}
