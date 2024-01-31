using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    public sealed class Stepped : BaseClass
    {
        private int array_size;
        private int[][] array;
        private bool user_fill = false;
        public Stepped(int k, bool t)
        {
            array_size= k;
            user_fill = t;
            Fill();
        }

        public override void Fill()
        {
            if (user_fill)
            {
                FillByUser(array_size);
            }
            else
            {
                RndmFill(array_size);
            }
        }

        private void RndmFill(int n)
        {
            array= new int[n][];
            for (int i = 0; i < array_size; i++)
            {
                Console.WriteLine("Введите количество элементов в строке массива");
                int current_array_size = int.Parse(Console.ReadLine());
                array[i] = new int[current_array_size];
                Random rnd = new Random();
                for (int j = 0; j < current_array_size; j++)
                {
                    array[i][j] = rnd.Next(10000);
                }
            }
        }

        private void FillByUser(int n)
        {
            array = new int[n][];
            for (int i = 0; i < array_size; i++)
            {
                Console.WriteLine("Введите количество элементов в строке массива");
                int current_array_size = int.Parse(Console.ReadLine());
                array[i] = new int[current_array_size];
                Console.WriteLine("Введите элементы строки массива:");
                for (int j = 0; j < current_array_size; j++)
                {
                    array[i][j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public override void mid_value()
        {
            double sum = 0;
            int cnt = 0;
            for (int i = 0; i < array_size; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                    cnt++;
                }
            }
            Console.WriteLine("Среднее значение во всём массиве: " + sum / cnt);
        }

        public override void array_output()
        {
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

