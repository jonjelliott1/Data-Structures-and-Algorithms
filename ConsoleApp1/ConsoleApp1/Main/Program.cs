////using System;
////using System.Diagnostics;

////namespace ConsoleApp1
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            Console.WriteLine("Hello World!");
////            //To manually call garbage collection type
////            GC.Collect();
////            GC.WaitForPendingFinalizers();

////            TimeSpan startingTime;
////            startingTime = Process.GetCurrentProcess.Threads(0).
////            UserProcessorTime;
////            var duration = Process.GetCurrentProcess.Threads(0).UserProcessorTime.Subtract(startingTime);

////            DateTime startTime;
////            TimeSpan endTime;
////            startTime = DateTime.Now;
////            //DisplayNums()
////            endTime = DateTime.Now.Subtract(startTime);

////            ////Example using the Node Class
////            //Node<string> node1 = new Node<string>("Mike", null);
////            //Node<string> node2 = new Node<string>("Raymond", node1);

////            ////Chapter 1 code 1
////            //collection names = new collection();
////            //names.Add("David");
////            //names.Add("Bernica");
////            //names.Add("Raymond");
////            //names.Add("Clayton");
////            //foreach (Object name in names)
////            //    Console.WriteLine(name);
////            //Console.WriteLine("Number of names:" + names.
////            //Count());
////            //names.Remove("Raymond");
////            //Console.WriteLine("Number of names:" + names.
////            //Count());
////            //names.Clear();
////            //Console.WriteLine("Number of names:" + names.
////            //Count());

////            //    //Chapter 1 Code 2
////            //    int num1 = 100;
////            //    int num2 = 200;
////            //    Console.WriteLine("num1:" + num1);
////            //    Console.WriteLine("num2:" + num2);
////            //    Swap<int>(ref num1, ref num2);
////            //    Console.WriteLine("num1:" + num1);
////            //    Console.WriteLine("num2:" + num2);
////            //    string str1 = "Sam";
////            //    string str2 = "Tom";
////            //    Console.WriteLine("String 1:" + str1);
////            //    Console.WriteLine("String 2:" + str2);
////            //    Swap<string>(ref str1, ref str2);
////            //    Console.WriteLine("String 1:" + str1);
////            //    Console.WriteLine("String 2:" + str2);


////            // }

////            //static void Swap<T>(ref T val1, ref T val2)
////            //{
////            //    T temp;
////            //    temp = val1;
////            //    val1 = val2;
////            //    val2 = temp;
////            //}

////        }

////        //an oversimplified timing test
////        static void DisplayNums(int[] arr)
////        {

////            for (int i = 0; i <= arr.GetUpperBound(0); i++)
////                Console.Write(arr[i] + " ");
////        }
////    }
////}

//using System;
//using System.Diagnostics;
//class chapter1
//{
//    static void Main()
//    {
//        int[] nums = new int[100000];
//        BuildArray(nums);
//        TimeSpan startTime;
//        TimeSpan duration;
//        startTime =
//        Process.GetCurrentProcess().Threads[0].
//        UserProcessorTime;
//        DisplayNums(nums);
//        duration =
//        Process.GetCurrentProcess().Threads[0].
//        UserProcessorTime.
//        Subtract(startTime);
//        Console.WriteLine("Time:" + duration.TotalSeconds);
//    }
//    static void BuildArray(int[] arr)
//    {
//        for (int i = 0; i <= 99999; i++)
//            arr[i] = i;
//    }
//    static void DisplayNums(int[] arr)
//    {
//        for (int i = 0; i <= arr.GetUpperBound(0); i++)
//            Console.Write(arr[i] + " ");
//    }
//}
