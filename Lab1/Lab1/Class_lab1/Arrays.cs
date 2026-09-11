using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Class_lab1
{
    internal class Arrays
    {
        public bool error = false;//Поле для перевірки на помилку
        double [] a;//закритий масив
        //закрита довжина масиву
        int length = 20;
        //властивість розмірність масиву
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        //індексатор
        public double this[int i]
        {
            get
            {
                if (0 <= i && i < length)
                    return a[i];
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if (0 <= i && i < length && value >= 100 && value <= 200)
                    a[i] = value;
                else
                    error = true;
            }
        }
        //Конструктори
        public Arrays()
        {
            a = new double[length];
        }
        public Arrays(double[] mas)
        {
            a = mas;
        }
        public Arrays(int size)
        {
            Length = size;
            a = new double[Length];
            Random rand = new Random();
            for (int i = 0; i < Length; i++)
            {
                this[i] =Math.Round( 100.0 + rand.NextDouble() * (200.0 - 100.0),2);
            }
        }
        //Властивість для обрахунку сум
        public (double, double, double) Sum
        {
            get
            {
                double S = 0, S_plus = 0, S_minus = 0;
                foreach (double i in a)
                {
                    S += i;
                    if (i > 0) S_plus += i;
                    else S_minus += i;
                }
                return (S, S_plus, S_minus);
            }
        }
        //Властивість для обрахунку суми непарних елементів
        public double OddSum
        {
            get
            {
                double S_odd = 0;
                for (int i = 1; i < length; i += 2)
                {
                    S_odd += a[i];
                }
                return S_odd;
            }
        }
        // Вивід одного елемента за індексом з перевіркою
        public string PrintElement(int i)
        {
            if (0 <= i && i < length)
            {
                error = false;
                return a[i].ToString("F2");
            }
            else
            {
                error = true;
                return "Помилка: вихід за межі масиву!";
            }
        }
        // Вивід усього масиву в рядок
        public string PrintAll()
        {
            if (a == null || length == 0) return "Масив порожній";
            return string.Join(" ", a);
        }
    }
}
