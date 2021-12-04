/*
    ~~~~ Linked List Algorithms ~~~~~~~
    Completed by Jose O Hidalgo on 12/05/2021
*/
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Algorithms
{
    class Program
    {
        Node head;
        static void Main(string[] args)
        {   
            LinkedList<string> listy = new LinkedList<string>();
            Program linkedList = new Program();
            Node firstNode = new Node(3);
            Node secondNode = new Node(4);
            Node thirdNode = new Node(5);
            Node fourthNode = new Node (6);

            linkedList.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;
            // ~~~~~~ 05 - Challenge - Rotation in  ~~~~~
            linkedList.displayContent();
            linkedList.deleteKthNodeFromEnd(3);
            Console.WriteLine();
            linkedList.displayContent();

            /* ~~~~~~ 03 - Algirthms ~~~~~ */
            

            /*linkedList.displayContent();
            linkedList.deleteBackHalf();
            Console.WriteLine();
            linkedList.displayContent();

            //~~~~~~ 01 - Operations ~~~~        
            listy.AddLast("Sarah");
            listy.AddLast("Polly");
            listy.AddLast("Rebecca");
            listy.AddLast("Jess");
            listy.AddLast("Jackie");
            
            Console.WriteLine(listy.Contains("Polly"));
            Console.WriteLine(listy.Count);

            listy.RemoveFirst();

            foreach(string item in listy)
            {
                Console.Write(item + "->");
            }
            Console.WriteLine();*/
        }

        // 04 - Challenge Delete Kth Element. 
        public void deleteKthNodeFromEnd(int k){
            if(head == null || k == 0){
                return;
            }
            
            Node first = head;
            Node second = head;

            for(int i = 0; i < k; i++){
                second = second.next;
                if(second.next == null){
                    //k>= Lenght of list
                    if(i == k -1){
                        head = head.next;
                    }
                    return;
                }
            }
            
            while(second.next != null){
                first = first.next;
                second = second.next;

            }
        }


        // 03 - Linked List
        public void deleteBackHalf()
        {
            if(head == null || head.next == null)
            {
                head = null;
            }

            Node slow = head;
            Node fast = head;
            Node prev = null;
            
            while(fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            prev.next = null;
        }

        public void displayContent()
        {
            Node current = head;
            
            while(current != null)
            {
                Console.Write(current.data + "->");
                current = current.next;
            }
        }

        public class Node {
            public int data;
            public Node next;

            public Node(int d) { data = d; }
        }
    }
}