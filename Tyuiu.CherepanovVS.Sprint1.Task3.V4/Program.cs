using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.CherepanovVS.Sprint1.Task3.V4.Lib;

namespace Tyuiu.CherepanovVS.Sprint1.Task3.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Черепанов В.С. | ПКТб-23-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*Спринт1                                                                   *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                  *");
            Console.WriteLine("*Задание #3                                                                *");
            Console.WriteLine("*Вариант #4                                                                *");
            Console.WriteLine("*Выполнил: Черепанов Вячеслав Сергеевич| ПКТб-23-1                         *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                  *");
            Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные,   *");
            Console.WriteLine("*выполняет указанные расчёты и печатает результат на экране.               *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                          *");
            Console.WriteLine("****************************************************************************");
            double priceNotebook = 2.75;
            Console.WriteLine("Стоимость тетрадок = " + priceNotebook);
            double priceCover = 0.5;
            Console.WriteLine("Стоимость обложек = " + priceCover);
            int quantity = 7;
            Console.WriteLine("Количество комплектов = " + quantity);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            var res = ds.PurchaseAmount(priceNotebook, priceCover, quantity);
            Math.Round(res, 3);
            Console.WriteLine("Стоимость покупки = " + ds.PurchaseAmount(priceNotebook, priceCover, quantity));
            Console.ReadLine();
        }
    }
}
