using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.CherepanovVS.Sprint1.Task4.V19.Lib;

namespace Tyuiu.CherepanovVS.Sprint1.Task4.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Черепанов В.С. | ПКТб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт1                                                                   *");
            Console.WriteLine("* Тема: Class Math                                                         *");
            Console.WriteLine("*Задание #4                                                                *");
            Console.WriteLine("*Вариант #19                                                               *");
            Console.WriteLine("*Выполнил: Черепанов Вячеслав Сергеевич| ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные,   *");
            Console.WriteLine("*вычисляет результат по формуле и печатает его на экране.                  *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            double x, y;
            Console.WriteLine("Введите значение переменной x = ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение переменной y = ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            var res = ds.Calculate(x, y);
            double res2 = Math.Round(res, 3); 
            Console.WriteLine("(x+y) / (x-2) = " + res2);
            Console.ReadLine();
        }
    }
}
