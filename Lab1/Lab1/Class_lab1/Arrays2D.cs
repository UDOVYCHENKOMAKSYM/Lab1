using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Class_lab1
{
    internal class Arrays2D
    {
        public bool error = false;//властивість помилки
        int x_lenght = 5;//розмірність 1
        int y_lenght = 5;//розмірність 2
        private int[,] a;//масив
        //Властивості для розмірностей
        public int X_lenght
        {
            get { return x_lenght; }
            set{x_lenght = value;}
        }
        public int Y_lenght
        {
            get { return y_lenght; }
            set{y_lenght = value;}
        }
        //Індексатор
        public int this[int i, int j]
        {
            get
            {
                if (0<=i && i < x_lenght && 0<=j && j < y_lenght)
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
                if (0 <= i && i < x_lenght && 0 <= j && j < y_lenght && value>=-10 && value<=10)
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
            Random rand = new Random();
            for (int i = 0; i < x_lenght; i++)
            {
                for (int j = 0; j < y_lenght; j++)
                {
                    a[i, j] = rand.Next(-10, 10);
                }
            }
        }
        //Конструктори
        public Arrays2D()
        {
            a = new int[x_lenght, y_lenght];
            generate();
        }
        public Arrays2D(int a_lenght, int b_lenght)
        {
            x_lenght = a_lenght;
            y_lenght = b_lenght;
            a = new int[x_lenght, y_lenght];
            generate();
        }
        //Обчислення суми та добутку
        public (int, int) Sum_Dob
        {
            get
            {
                int P = 1, S = 0;
                foreach (int i in a)
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
            

    }
}
