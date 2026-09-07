using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Class_lab1
{
    internal class Tabul
    {
        //Поле з результуючим масивом
        public double[,] xy = new double[1000, 2];
        //Реальна кількість елементів масиву
        public int n = 0;
        //Методи для обрахунку функцій
        private double f1(double x)
        {
            return 2 * Math.Sqrt(Math.Abs(Math.Pow(x, 3))) * Math.Sin(Math.Pow(x, 3));
        }
        private double f2(double x)
        {
            return Math.Pow((x+1),2) * Math.Cos(Math.Pow(x, 3));
        }
        private double f3(double x)
        {
            return Math.Sqrt(Math.Pow(x,4)+2)+Math.Sin(Math.Pow(x,2));
        }
        //Метод табулювання
        public void tab(double xn = -1.25, double xk = 67.32, double xh = 0.3, double a = 0.5)
        {
            double x = xn, y;
            int i = 0;
            while (x <= xk)
            {
                if (x <= 0)
                {
                    y = f1(x);
                }
                else
                {
                    if (x > 0 && x <= a)
                    {
                        y = f2(x);
                    }
                    else
                    {
                        y = f3(x);
                    }
                }
                xy[i, 0] = x;
                xy[i, 1]= y;
                x = x + xh;
                i++;
            }
            n = i;
        }

    }
}
