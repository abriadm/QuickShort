namespace QuickShort
{
    internal class Program
    {


        private int[] arr = new int[20];
        private int cmp_count = 0;
        private int mov_count = 0;

        private int n;

        void read()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 20 element \n");
            }

            Console.WriteLine("\n======================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n======================");

            for(int i =0;i < n;i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }

        void swap(int x, int y)
        {
            int temp;

            temp = arr[x];
            arr[x] = arr[y];
        }

        public void q_sort(int low, int high)
        {
            int pivot, i, j;
            if(low > high)
                return;

            //Partition the list into two parts
            //one containing elements less that or equal to pivot
            //outher containing 

            i = low + 1;
            j = high;

            pivot = arr[low];

            while (i <= j)
            {
                while ((arr[i] <= pivot) && (i <= high))
                {
                    j--;
                    cmp_count++;
                }
                cmp_count++;

                if(i < j) //if the greater element is on the left of the element
                {
                    //swap the element at index i with the element at index j
                    swap(i, j);
                    mov_count++;
                }
            }
            //j now contains the index of the last element in the sorted list

            if (low < j)
            {
                //move the pivot to its correct position in the list
                swap(low, j);
                mov_count++;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}