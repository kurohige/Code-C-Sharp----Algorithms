/*
    ~~~~ Array Algorithms ~~~~~~~
*/
using System;
using System.Linq;
using System.Text;
using System.Collections;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 2, 3, 4, 5, 6};
            int[] arrOne = {-8, 2, 3, -9, 11, -20};
            int[] arrTwo = {0, -2, -9, 39, -39, 10, 7};

            
            // ~~~~~~ 05 - Challenge - Rotation in  ~~~~~~
            ReverseInPlaceToLeft(arr);
            Array.ForEach(arr, Console.WriteLine);
            Console.WriteLine("Start new count");
            ReverseInPlaceToRight(arr);
            Array.ForEach(arr, Console.WriteLine);


            /* ~~~~~~ 04 - Reverse an Array in C# ~~~~~~
            //Array.ForEach(Reverse(arr), Console.WriteLine);
            //ReverseInPlace(arr);
            //Array.ForEach(arr, Console.WriteLine);
            //ReverseInPlace(arr);
            //Array.ForEach(arr, Console.WriteLine);*/ 


            /* ~~~~~~ 03 - Aggregate and filter arrays ~~~~~~
            //int[] evenArr = FindEvenNums(arrOne, arrTwo);
            //Array.ForEach(evenArr, Console.WriteLine);

            /*~~~~~~ 02 - Binary Search ~~~~
            // Console.WriteLine(BinarySearch(arr, 4));
            // Console.WriteLine(BinarySearch(arr, 7));
            // Console.WriteLine(BinarySearch(arr, 0));
            //Console.WriteLine(BinarySearch(arr, 3));

            /* ~~~~~~ 01 - Linear Search ~~~~        
            // Console.WriteLine(LinearSearch(arr,4));
            // int item = Array.Find(arr, element => element == 3);
            // Console.WriteLine(item);
            // int[] items = Array.FindAll(arr, element => element >= 5);
            //Array.ForEach(items, Console.WriteLine);*/


        }

        // Challenge
        static void ReverseInPlaceToLeft(int[] input)
        {
            for(int i= 0; i < input.Length - 1; i++)
            {
                int temp;
                if(i == 0)
                {
                    temp = input[i];
                    input[i] = input[input.Length -1];
                    input[input.Length -1] = temp;
                }
                else{
                    temp = input[i-1];
                    input[i-1] = input[i];
                    input[i] = temp;
                }
            }
        }

        // Bonus Challenge:
        static void ReverseInPlaceToRight(int[] input)
        {
            int temp = input[input.Length-1];
            for(int i= input.Length-1; i > 0 ; i--)
            {
                input[i] = input[i -1];
            }
            input[0] = temp;
        }

        // Reverse an Array in C#

        static void ReverseInPlace(int[] input)
        {
            for(int i= 0; i < input.Length /2; i++)
            {
                //Swap Index(i) with index(input.length -i -1)
                int temp = input[i];
                input[i] = input[input.Length -i -1];
                input[input.Length -i -1] = temp;
            }
        }
        static int[] Reverse(int[] input)
        {
            int[] reversed = new int[input.Length];

            for(int i= 0; i < reversed.Length;i++)
            {
                reversed[i] = input[input.Length -i -1];
            }

            return reversed;

        }

        //Agregate and filter Arrays
        static int[] FindEvenNums(int[] arrOne, int[] arrTwo)
        {
            ArrayList result = new ArrayList();
            foreach(int num in arrOne)
            {
                if(num % 2 == 0)
                {
                    result.Add(num);
                }

            }

            foreach(int num in arrTwo)
            {
                if(num % 2 == 0)
                {
                    result.Add(num);
                }
                
            }

            return (int[])result.ToArray(typeof(int));
        }

        // Binary Search
        static Boolean BinarySearch(int[] inputArray, int item)
        {
            int min = 0;
            int max = inputArray.Length -1;

            while(min <= max)
            {
                int mid = (min + max) / 2;
                if(item == inputArray[mid])
                {
                    return true;
                }
                else if (item < inputArray[mid])
                {
                    max = mid - 1;
                }
                else 
                {
                    min = mid + 1;
                }
            }
            return false;
        }

        //Linear Search
        static Boolean LinearSearch(int[] input, int n) 
        {
            foreach(int current in input)
            {
                if(n == current)
                {
                    return true;
                }
            }
            return false;
        }


    }
}