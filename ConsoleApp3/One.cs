using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public sealed class One : BaseClass
    {
        private int array_size;
        private bool user_fill = false;

        public One(int cnt, bool t)
        {
            array_size= cnt;
            user_fill = t;
            Fill();
        }
        private int[] array;

        private void FillByUser(int m)
        {
            Console.WriteLine("Введите элементы массива:");
            array= new int[m];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        private void RndmFill(int m)
        {
            array = new int[m];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100000);
            }
        }

        public override void Fill()
        {
            if (!user_fill)
            {
                RndmFill(array_size);
            }
            else
            {
                FillByUser(array_size);
            }
        }

        public override void array_output()
        {
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public override void mid_value()
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Среднее значение в массиве: " + sum / array.Length);
        }

    }
}
