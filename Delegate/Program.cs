using System;
using System.Collections.Generic;

namespace Delegate
{
    class Program
    {
        #region Delegate,Action

        //public delegate bool CheckNums(int num);

        //public delegate void ChangeString(string str);

        //public delegate int StringLength(string str,int m);

        public static void Main(string[] args)
        {
            //int[] arr = { 7, 5, 4, 6, 8, 9 };
            //Console.WriteLine(SummOdd(CheckOdd,arr));
            //Console.WriteLine(SummEven(CheckEven,arr));
            //Console.WriteLine(SummMoreThanFive(CheckMoreThanFive,arr));

            //List<int> numbers = new List<int>() { 9, 8, 7, 6, 5, 4, 3 };

            //var result = numbers.FindAll(m => m > 6 && m < 9);
            //var result2 = numbers.FindAll(CheckMoreThanFive);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //ChangeString change = new ChangeString(StringToUpper);
            //change.Invoke("Cavidan");

            //ChangeString change1 = StringToUpper;
            ////change += StringToLower;
            ////change += delegate (string s)
            ////{
            ////    Console.WriteLine(s.ToLower());
            ////};

            //change += s => Console.WriteLine(s.ToLower());

            //change("Cavidan");

            //Action<string, int, string> action = StringToUpper;
            //action += StringToLower;
            //action("Cavidan",17,"Age");

            //Console.WriteLine(Test(StrLength, "Cavidan"));

            //Func<string, int, string> func = StrLength;

            //Console.WriteLine(func("Cavidan",17));
        }

        //public static string StrLength(string str,int m)
        //{
        //    return str.Length.ToString() + "-Age:" + m;
        //}

        //public static string Test(StringLength func,string str,int m)
        //{
        //    return func(str,m);
        //}


        //public static void StringToUpper(string str,int n,string t)
        //{
        //    Console.WriteLine(str.ToUpper() + "-" + n + t);
        //}

        //public static void StringToLower(string str,int n,string t)
        //{
        //    Console.WriteLine(str.ToLower() + "-" + n + t);
        //}


        //public static void Test() => Console.WriteLine("tested");

        //public static bool CheckOdd(int number)
        //{
        //    return number % 2 != 0;
        //}

        //public static bool CheckEven(int number)
        //{
        //    return number % 2 == 0;
        //}

        //public static bool CheckMoreThanFive(int number)
        //{
        //    return number > 6;
        //}


        //public static int Sum(Predicate<int> predicate, int[] nums)
        //{
        //    var sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (item % 2 != 0)
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}


        //public static int SummEven(Predicate<int> predicate, int[] nums)
        //{
        //    var sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if(item % 2 == 0)
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}


        //public static int SummMoreThanFive(Predicate<int> predicate,int[] nums)
        //{
        //    var sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (item > 6)
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}

        #endregion Delegate,Action
    }
}
