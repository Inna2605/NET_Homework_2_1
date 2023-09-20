//Оголосити одновимірний (5 елементів) масив з назвою А і двовимірний масив (3 рядки, 4 стовбці) дробових чисел з назвою В.
//Заповнити одновимірний масив А числами, введеними з клавіатури користувачем, а двовимірний масив В - випадковими числами
//за допомогою циклів. Вивисти на екран: масив А - в один рядок, масив В - у вигляді матриці.
//Знайти у даних масивах загальний максимальний елемент, мінімальний елемент, загальну суму усіх елементів, загальний
//добуток усіх елементів, суму парних елементів масиву А, суму непарних стовбців масиву В.
using System;

namespace NET_Homework_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double [] A = new double[5];//Оголосили одновимірний масив А (5 елементів)
            double[,] B = new double[3,4];//Оголосили двовимірний масив В (3 рядки, 4 стовбці)
            Random random = new Random();

            for(int i = 0; i < A.Length; i++)//Заповнення одновимірного масиву А з клавіатури
            {
                Console.Write("Введіть елемент " + (i + 1) + " масиву А: ");
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            double max = A[0], min = A[0], sum = 0, multy = 1, even = 0;
            
            Console.WriteLine("\nВиведення одновимірного масиву А:");
            foreach (int i in A)
            {
                if (i > max) //Знаходження максимального елементу в масиві А
                {
                    max = i;       
                }else if (i < min)//Знаходження мінімального елементу в масиві А
                {
                    min = i;
                }
                sum += i;//Знаходження суми елементів масиву А
                multy *= i;//Знаходження добутку елементів масиву А
                if (i % 2  == 0)//Знаходження суми парних елементів масиву А
                {
                    even += i;
                }
                Console.Write(i + " ");//Вивод одновимірного масиву А на екран
            }

            Console.WriteLine("\n\nМаксимальний елемент масиву А: " + max);
            Console.WriteLine("Мінімальний елемент масиву А: " + min);
            Console.WriteLine("Сума елементів масиву А: " + sum);
            Console.WriteLine("Добуток елементів масиву А: " + multy);
            Console.WriteLine("Сума парних елементів масиву А: " + even);

            Console.Write("\n\n");
            Console.WriteLine("Виведення двовимірного масиву В:");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for(int j = 0; j < B.GetLength(1); j++)
                {
                    B[i,j] = random.NextDouble();//Заповнення двовимірного масиву В рандомними дробовими числами
                    Console.Write(B[i,j] + " ");//Вивод двовимірного масиву В на екран
                }
                Console.WriteLine();
            }

            double max_d = B[0, 0], min_d = B[0, 0], sum_d = 0, multy_d = B[0, 0], odd = 0;

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (max_d < B[i, j])//Знаходження максимального елементу в масиві В
                    {
                        max_d = B[i, j];
                    }
                    else if (min_d > B[i, j])//Знаходження мінімального елементу в масиві В
                    {
                        min_d = B[i, j];
                    }
                    if (j == 0 || j %2 == 0)//Знаходження суми непарних елементів масиву В
                    {
                        odd += B[i, j];
                    }
                    sum_d += B[i, j];//Знаходження суми елементів масиву В
                }
            }
            for (int i = 0; i < B.GetLength(0); i++)//Знаходження добутку елементів масиву В
            {
                for (int j = 1; j < B.GetLength(1); j++)
                {
                    multy_d *= B[i, j];
                }
            }
            Console.WriteLine("\n\nМаксимальний елемент масиву В: " + max_d);
            Console.WriteLine("Мінімальний елемент масиву В: " + min_d);
            Console.WriteLine("Сума елементів масиву В: " + sum_d);
            Console.WriteLine("Добуток елементів масиву B: " + multy_d);
            Console.WriteLine("Сума елементів непарних стовпців масиву B: " + odd);

            double Max = 0, Min = 0;

            if (max <= max_d)
            {
                Max = max_d;
                Console.WriteLine("\n\nМаксимальний загальний елемент двох масивів: " + Max);
            }
            else if (max > max_d)
            {
                Max = max;
                Console.WriteLine("\n\nМаксимальний загальний елемент двох масивів: " + Max);
            }
            if (min <= min_d) 
            {
                Min = min;
                Console.WriteLine("Мінімальний загальний елемент двох масивів: " + Min);
            }
            else if(min > min_d)
            {
                Min = min_d;
                Console.WriteLine("Мінімальний загальний елемент двох масивів: " + Min);
            }
            Console.WriteLine("Загальна сума всіх елементів двох масивів: " + (sum + sum_d));
            Console.WriteLine("Загальний добуток всіх елементів двох масивів: " + (multy * multy_d));
            Console.ReadLine();
        }
    }
}
