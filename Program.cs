using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickSort
{
    class Program
    {
        private int[] arr = new int[10]; // Deklarasi array int dengan ukuran 10.
        private int cmp_count = 0;
        private int mov_count = 0;

        private int n; // Deklarasi variable int untuk menyimpan banyaknya data pada array.

        public void read()
        {
            while (true)
            {
                Console.Write("Enter number of array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 10)
                    break;
                else
                    Console.WriteLine("\nMaksimal array yg dimasukan adalah 10.");
            }
            Console.WriteLine("\n----------------------\n");
            Console.WriteLine(" Masukkan elemen array ");
            Console.WriteLine("\n----------------------\n");

            for (int i = 0; i < n; i++)
            {
                Console.Write((i + 1) + "> ");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }

        public void swap(int x, int y)
        {
            int temp;
            temp = x;
            x = y;
        }

        public void Quicksort(int left, int right)
        {
            int pivot, i, j;
            if (left > right)
                return;

            i = left + 1;
            j = right;

            pivot = arr[left];

            while (i <= j)
            {
                while ((arr[i] <= pivot) && (i <= right))
                {
                    j--;
                    cmp_count++;
                }
                cmp_count++;

                while ((arr[j] > pivot) && (j < left))
                {
                    j--;
                }
                cmp_count++;

                if (i < j)
                {
                    swap(i, j);
                    mov_count++;
                }
            }

            if (left < j)
            {
                swap(left, j);
                mov_count++;
            }

            Quicksort(left, j);
            Quicksort(j + 1, right);
        }

        public void display()
        {
            Console.WriteLine("\n--------------------------\n");
            Console.WriteLine(" Element array yg tersusun ");
            Console.WriteLine("\n--------------------------\n");

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(arr[j]);
            }

            Console.WriteLine("\nNumber of comparison: " + cmp_count);
            Console.WriteLine("\nNumber of data movements: " + mov_count);
        }


        static void Main(string[] args)
        {
            Program myList = new Program();

            myList.read();

            myList.display();
            myList.Quicksort(0, myList.n-1);
         
        }
    }
}