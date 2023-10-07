using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.CherepanovVS.Sprint1.Task7.V2.Lib;

namespace Tyuiu.CherepanovVS.Sprint1.Task7.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Черепанов В.С. | ПКТб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт1                                                                   *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                  *");
            Console.WriteLine("*Задание #7                                                                *");
            Console.WriteLine("*Вариант #2                                                                *");
            Console.WriteLine("*Выполнил: Черепанов Вячеслав Сергеевич| ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по        *");
            Console.WriteLine("* исходным значениям данных, вводимых пользователем. Ответ округлите до 3  *");
            Console.WriteLine("* знаков после запятой.                                                    *");
            Console.WriteLine("                                                                            ");
            Console.WriteLine("       sin(x)+cos(y)");
            Console.WriteLine("  z = --------------- tg(xy)");
            Console.WriteLine("       cos(x)-sin(y)");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("Введите значение x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y = ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            double z = ds.Calculate(x, y);
            double res = Math.Round(z, 3);
            Console.WriteLine("Выражение = " + res);
            Console.ReadLine();
        }
    }
}
