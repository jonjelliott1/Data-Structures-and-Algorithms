using System;

namespace SortingAlgorithms
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Sorting algorithms you should study first...
    //        // 1. Insertion sort
    //        // 2. bublle sort
    //        // 3. selection sort

            
            
    //        Console.WriteLine("Hello World!");
    //    }
    //}
    //array class test bed

    class CArray
    {
        private int[] arr;
        private int upper;
        private int numElements;
        public CArray(int size)
        {
            arr = new int[size];
            upper = size - 1;
            numElements = 0;

        }
        public void Insert(int item)
        {
            arr[numElements] = item;
            numElements++;

        }
    
    public void DisplayElements()
        {
            for (int i = 0; i <= upper; i++)
                Console.Write(arr[i] + " ");
        }
    
        public void Clear()
        {
            for (int i = 0; i <= upper; i++)
                arr[i] = 0;
            numElements = 0;

        }

        public void BubbleSort()
        {
            int temp;
            for (int outer = upper; outer >= 1; outer--)
            {
                Console.WriteLine("Start Outer for"+ "inner: " + outer);
                // if inner value is less than or equal to outer value
                // or if first value is greater than last
                for (int inner = 0; inner <= outer - 1; inner++)
                    //if first is greater than second then
                    if ((int)arr[inner] > arr[inner + 1])
                    {
                        //This swaps the item on the left with the item adjacent on the right
                        //set first to temp
                        Console.WriteLine("Swapping " + arr[inner] + " in loc: " +inner+ " with " + arr[inner + 1] + " in loc: " + (inner + 1));
                        temp = arr[inner];
                        //move adjecent to first to first
                        arr[inner] = arr[inner + 1];
                        //set item that was in first into the place second was in.
                        arr[inner + 1] = temp;
                        
                        
                    }
                Console.WriteLine("End Outer for" + "outer: " + outer);
                this.DisplayElements();
            }
        }
        ////array of numbers 0 - 49
        //static void Main()
        //{
        //    CArray nums = new CArray(50);
        //    for (int i = 0; i <= 49; i++)
        //        nums.Insert(i);
        //    nums.DisplayElements();
        //}

        //array of 10 random numbers
        static void Main()
        {
            CArray nums = new CArray(50);
            Random rnd = new Random(100);
            for (int i = 0; i < 50; i++)
                nums.Insert((int)(rnd.NextDouble() * 100));
            nums.DisplayElements();
            nums.BubbleSort();
            Console.WriteLine();
            nums.DisplayElements();
        }


    }
    
}
