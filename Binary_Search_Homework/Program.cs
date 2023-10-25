using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Binary_Search_Homework
{
    internal class Program
    {
        static void Main(string[] args) // feel free to edit the main method as you like
        {
            //int[] a = new int[] { 1, 2, 4, 4, 5, 6, 7, 8, 9 };
            //int key = 2;

            //int idx = BinarySearchHomework.TernarySearch(a, key, 0, a.Length);

            //Console.WriteLine("Found {0} at index {1} using Ternary Search", key, idx);

            //Console.WriteLine("=======================");

            //int[] arr2 = { 1, 2, 2, 2, 3, 4, 5, 5, 5, 5, 5, 6, 7, 7, 8, 9 };
            

            //int repeat_count = BinarySearchHomework.GetRepeatCount(arr2, key);

            //Console.WriteLine("the number 2 is repeated {0} times", repeat_count);
            int[] arr = { 1, 2, 2, 2, 3, 4, 5, 5, 5, 5, 5, 6, 7, 7, 8, 9 };
            int key = 9;

            // pass true for the first occurrence
            int last = BinarySearchHomework.BinarySearchForCalculatingRepeated(arr, key, false, 0, arr.Length);
            Console.WriteLine(last);


        }
    }
}
