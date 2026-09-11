using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Class_lab1
{
    internal class Arrays2D
    {
        public bool error = false;//властивість помилки
        int x_length = 7;//розмірність 1
        int y_length = 7;//розмірність 2
        private double[,] a;//масив
        //Властивості для розмірностей
        public int X_length
        {
            get { return x_length; }
            set{x_length = value;}
        }
        public int Y_length
        {
            get { return y_length; }
            set{y_length = value;}
        }
        //Індексатор
        public double this[int i, int j]
        {
            get
            {
                if (0<=i && i < x_length && 0<=j && j < y_length)
                {
                    return a[i, j];
                }
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if (0 <= i && i < x_length && 0 <= j && j < y_length)
                {
                    a[i,j] = value;
                }
                else
                {
                    error = true;
                    
                }
            }
        }
        void generate()
        {
            for (int j = 0; j < y_length; j++)
            {
                int col = j + 1; // номер стовпця від 1 до 7
                a[0, j] = 2.0 * col + 3.0;
                a[1, j] = col + 3.0 / (2.0 + col);
            }

            for (int i = 2; i < x_length; i++)
            {
                for (int j = 0; j < y_length; j++)
                {
                    a[i, j] = a[i - 1, j] + a[i - 2, j];
                }
            }
        }
        //Конструктори
        public Arrays2D()
        {
            a = new double[x_length, y_length];
            generate();
        }
        public Arrays2D(int a_length, int b_length)
        {
            x_length = a_length;
            y_length = b_length;
            a = new double[x_length, y_length];
            generate();
        }
        //Обчислення суми та добутку
        public (double, double) Sum_Dob
        {
            get
            {
                double P = 1, S = 0;
                foreach (double i in a)
                {
                    if (i > 0)
                    {
                        P *= i;
                    }
                    else
                    {
                        S += i;
                    }

                }
                return (S, P);
            } 
            
        }
        // Вивід одного елемента за індексами
        public string PrintElement(int i, int j)
        {
            if (0 <= i && i < x_length && 0 <= j && j < y_length)
            {
                error = false;
                return a[i, j].ToString("F2");
            }
            else
            {
                error = true;
                return "Помилка: вихід за межі матриці!";
            }
        }
        // Вивід усієї матриці
        public string PrintAll()
        {
            if (a == null) return "Матриця порожня";

            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < x_length; i++)
            {
                for (int j = 0; j < y_length; j++)
                {
                    sb.Append(a[i, j].ToString("F2").PadLeft(5)); // гарне вирівнювання стовпців
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }


    }
}
