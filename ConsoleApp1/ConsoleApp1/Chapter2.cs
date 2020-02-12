
//using System;
//using System.Diagnostics;
//class Chapter2
//{
//    static void Main()
//    {


//        ////examples of simple arrays
//        //string[] names = new string[10];

//        //int[] numbers = new int[] { 1, 2, 3, 4, 5 };

//        //for (int i = 0; i <= numbers.GetUpperBound(0); i++)
//        //    Debug.WriteLine(numbers[i] + " ");

//        ////examples of multidimensional arrays

//        //int[,] grades = new int[,] {{1, 82, 74, 89, 100},
//        //                            {2, 93, 96, 85, 86},
//        //                            {3, 83, 72, 95, 89},
//        //                            {4, 91, 98, 79, 88 }};

//        //var grade = grades[1, 2];

//        ////calculating the grade average of each student

//        //int last_grade = grades.GetUpperBound(1);
//        //double average = 0.0;
//        //int total;
//        //int currentGrade;
//        //int last_student = grades.GetUpperBound(0);
//        //for (int row = 0; row <= last_student; row++)
//        //{
//        //    total = 0;
//        //    for (int col = 0; col <= last_grade; col++)
//        //    {
//        //        currentGrade = grades[row, col];
//        //        Console.WriteLine("Print " + currentGrade);
//        //        total += grades[row, col];

//        //    }

//        //    average = total / (last_grade + 1);
//        //        Console.WriteLine("Average: " + average);



//        //    //How to create a static function that sums an array of numbers
//        //    int total;
//        //    total = sumNums(1, 2, 3);
//        //    total = sumNums(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

//        //}

//        //    static int sumNums(params int[] nums)
//        //    {
//        //        int sum = 0;
//        //        for (int i = 0; i <= nums.GetUpperBound(0); i++)
//        //            sum += nums[i];
//        //        return sum;
//        //    }

//        int[][] jagged = new int[12][];

//        jagged[0][0] = 23;
//    }

//}

