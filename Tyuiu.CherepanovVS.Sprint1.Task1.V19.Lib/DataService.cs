using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.CherepanovVS.Sprint1.Task1.V19.Lib
{
    public class DataService1 : ISprint1Task1V19
    {
        public double Calculate(double x, double y)
        {
            return ((1 + 3 * x) / (4 * y));
        }
    }
}
