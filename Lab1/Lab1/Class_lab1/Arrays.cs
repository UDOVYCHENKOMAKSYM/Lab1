using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Class_lab1
{
    internal class Arrays
    {
        public bool error = false;//Поле для перевірки на помилку
        int[] a;//закритий масив
        //закрита довжина масиву
        int lenght = 5;
        //властивість розмірність масиву
        public int Lenght
        {
            get { return lenght; }
            set { lenght = value; }
        }
        //індексатор
        public int this[int i]
        {
            get
            {
                if (0 <= i && i < lenght)
                    return a[i];
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if (0 <= i && i < lenght && value >= -100 && value <= 100)
                    a[i] = value;
                else
                    error = true;
            }
        }
        //Конструктори
        public Arrays()
        {
            a = new int[lenght];
        }
        public Arrays(int[] mas)
        {
            a = mas;
        }
        public Arrays(int size)
        {
            Lenght = size;
            a = new int[lenght];
            Random rand = new Random();
            for (int i = 0; i < lenght; i++)
            {
                this[i] = rand.Next(-50, 50);
            }
        }
        //Властивість для обрахунку сум
        public (int, int, int) Sum
        {
            get
            {
                int S = 0, S_plus = 0, S_minus = 0;
                foreach (int i in a)
                {
                    S += i;
                    if (i > 0) S_plus += i;
                    else S_minus += i;
                }
                return (S, S_plus, S_minus);
            }
        }
    }
}
