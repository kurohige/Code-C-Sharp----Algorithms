/*
    ~~~~ 04 - Queue and Stack Algorithms ~~~~~~~
    Completed by Jose O Hidalgo on 12/06/2021
*/
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            Stack<string> stack = new Stack<string>();

            /* ~~~~~~ 04 - Implementing next greater elem ~~~~~~~~*/
            int[] arr = new int[] {15, 8, 4, 10};
            int[] arrTwo = new int[] {2};
            int[] arrThree = new int[] {2, 3};
            int[] arrFour = new int[] {};

            printNextGreaterElement(arr);
            printNextGreaterElement(arrTwo);
            printNextGreaterElement(arrThree);
            printNextGreaterElement(arrFour);



            /* ~~~~~~ 03 - Basic Stack Operations ~~~~~~~~
            // Console.WriteLine("Start Main");
            // stack.Push("Main");
            // Console.WriteLine("Start ResponseBuilder");
            // stack.Push("ResponseBuilder");
            // Console.WriteLine("Start CallExternalService");
            // stack.Push("CallExternalService");
            // Console.WriteLine("END " + stack.Pop());
            // Console.WriteLine("Start ParseExternalData");
            // stack.Push("ParseExternalData");
            // Console.WriteLine("END " + stack.Pop());
            // Console.WriteLine("END " + stack.Pop());
            // Console.WriteLine("END " + stack.Pop());

            // string item;
             Console.WriteLine(stack.TryPeek(out item));
             */



            // ~~~~~~ 02 - Generate binary numbers ~~~~~~~~
            // printBinary(5);
            // printBinary(-2);
            // printBinary(0);
            // printBinary(2);
            // printBinary(8);


            /* ~~~~~~ 01 - Standard Queue Operations ~~~~~~
            // queue.Enqueue(1);
            // queue.Enqueue(8);
            // queue.Enqueue(20);
            // queue.Enqueue(23);
            // queue.Enqueue(25);

            // int removeItem = queue.Dequeue();
            // Console.WriteLine(removeItem);
            // Console.WriteLine(queue.Dequeue());
            // Console.WriteLine(queue.Peek());

            // int current;
            // while(queue.TryDequeue(out current))
            // {
            //     Console.WriteLine(current);
             }*/ 
            
        }

        // ~~~~ 04 ~~~~~
        static void printNextGreaterElement(int[] arr)
        {
            if( arr.Length <= 0){
                Console.WriteLine();
                return;
            }
            Stack<int> stack = new Stack<int>();
            stack.Push(arr[0]);

            for(int i = 1; i < arr.Length; i++)
            {
                int next = arr[i];
                if(stack.Count > 0)
                {
                    int popped = stack.Pop();

                    while(popped < next)
                    {
                        Console.WriteLine(popped + " --> " + next);
                        if(stack.Count == 0)
                        {
                            break;
                        }
                        popped = stack.Pop();
                   }

                   if(popped > next)
                   {
                       stack.Push(popped);
                   }
                }
                stack.Push(next);
            }

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop() + " --> " + -1);
            }

        }

        static void printBinary(int n){
            if(n<= 0)
            {
                return;
            }
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            for(int i = 0; i<n; i++)
            {
                int current = queue.Dequeue();
                Console.WriteLine(current);
                queue.Enqueue(current *10);
                queue.Enqueue(current * 10 + 1);
            }
            Console.WriteLine();
        }

    }
}