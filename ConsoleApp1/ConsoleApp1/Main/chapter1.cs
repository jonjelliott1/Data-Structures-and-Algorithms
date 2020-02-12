using System;
using System.Diagnostics;

public class Timing
    {
        TimeSpan startingTime;
        TimeSpan duration;
        public Timing()
        {
            startingTime = new TimeSpan(0);
            duration = new TimeSpan(0);
        }
        public void StopTime()
        {
            duration =
            Process.GetCurrentProcess().Threads[0].
            UserProcessorTime.Subtract(startingTime);
        }
        public void startTime()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            startingTime =
            Process.GetCurrentProcess().Threads[0].
            UserProcessorTime;
        }
        public TimeSpan Result()
        {
            return duration;
        }
    }


    //class chapter1
    //{
    //    static void Main()
    //    {
    //        int[] nums = new int[100000];
    //        BuildArray(nums);
    //        Timing tObj = new Timing();
    //        tObj.startTime();
    //        DisplayNums(nums);
    //        tObj.StopTime();
    //    var t1 = tObj.Result();
    //        Console.WriteLine("time (.NET):" + tObj.Result());
    //    }
    //    static void BuildArray(int[] arr)
    //    {
    //        for (int i = 0; i < 100000; i++)
    //            arr[i] = i;
    //    }
    //    static void DisplayNums(int[] arr)
    //    {
    //        for (int i = 0; i <= arr.GetUpperBound(0); i++)
    //            Console.Write(arr[i] + " ");
    //    }
    //}