using System;

namespace task_3_1
{
    public class One_dimensional
    {
        private int[] array;
        public One_dimensional(int a)
        {
            array = new int[a];
        }
        public int this[int i]
        {
            set
            {
                array[i] = value;
            }
            get
            {
                return array[i];
            }
        }
        public int[] Array()
        {
            return array;
        }


        public double Average()
        {
            double a = 0;
            double i = 0;
            foreach (int el in array)
            {
                a += el;
                i++;
            }
            return a / i;
        }
        public void Clear100()
        {
            int length = 0;
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > -100 && array[i] < 100)
                {
                    length++;
                }
            }
            int[] a = new int[length];
            foreach (int el in array)
            {
                if (el > -100 && el < 100)
                {
                    a[k] = el;
                    k++;
                }
            }
            array = a;
        }
        public void ClearSame()
        {
            int length = 0;
            int p = 0;
            int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                p = 0;
                for (int x = 0; x < array.Length; x++)
                {
                    if (array[x] == array[i])
                    {
                        p++;
                    }
                }
                if (p == 1)
                {
                    length++;
                }
            }
            int[] a = new int[length];
            int m = 0;
            foreach (int el in array)
            {
                m = 0;
                for (int c = 0; c < array.Length; c++)
                {
                    if (array[c] == el)
                    {
                        m++;
                    }
                }
                if (m == 1)
                {
                    a[k] = el;
                }
                k++;
            }

            array = a;
        }

        public void Show()
        {
            foreach (int el in array)
            {
                Console.WriteLine(el);
            }
        }
    }
    public class Two_dimensional
    {
        private int[,] array;
        private int A;
        private int B;
        public Two_dimensional(int a, int b)
        {
            array = new int[a, b];
            A = a;
            B = b;
        }
        public int this[int i, int q]
        {
            set
            {
                array[i, q] = value;
            }
            get
            {
                return array[i, q];
            }
        }
        public double Average()
        {
            double s = 0;
            int k = 0;
            for(int i = 0; i < A; i++)
            {
                for(int z = 0; z < B; z++)
                {
                    s += array[i,z];
                    k += 1;
                }
            }
            return s / k;
        }
        public void ShowMatrix()
        {
            for (int i = 0; i < A; i++)
            {
                for (int z = 0; z < B; z++)
                {
                    Console.Write(array[i, z] + "  ");
                }
                Console.WriteLine("");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random();
            int x = n.Next(3, 10);
            int y = n.Next(3, 7);
            One_dimensional array1 = new One_dimensional(x);
            for (int i = 0; i < x; i++)
            {
                array1.Array()[i] = n.Next(-150, 150);
            }
            array1.Show();
            Console.WriteLine(array1.Average());
            array1.Clear100();
            array1.ClearSame();
            array1.Show();

            Two_dimensional array2 = new Two_dimensional(x, y);
            for(int i = 0; i < x; i++)
            {
                for(int q = 0; q < y; q++)
                {
                    array2[i, q] = n.Next(-150, 150);
                }
            }
            array2.ShowMatrix();
            Console.WriteLine(array2.Average());

            Console.ReadKey();
        }
    }
}