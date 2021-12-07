/*
    ~~~~ 05 - Hash-Based Struct Algorithms ~~~~~~~
    Completed by Jose O Hidalgo on 12/07/2021
*/
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Algorithms
{
    
    class Employee
    {
        string name;
        int id;
        string department;

        public Employee(string name, int id, string department)
        {
            this.name = name;
            this.id = id;
            this.department = department;
        }
        static void Main(string[] args)
        {
            Employee employeeOne = new Employee("Robby", 3827, "Technology");
            Employee employeeTwo = new Employee("Bobby", 9415, "Marketing");
            Employee employeeThree = new Employee("Sally", 2519, "Sales");

            // ~~~~~~ 03 - Dictionary type ~~ ~~~~~
            displayFreqOfEachElement(new int[] {3, 0, 2, 4, 7, 3, 4, 5, 7, 6, 7 });
             


            /* ~~~~~~ 02 - Leverage the HashSet type ~~~~~~~
            
            // findMissingElements(new int[] {1, 2, 3, 4}, new int[] {2, 4}).ForEach(Console.WriteLine);
            // Console.WriteLine();
            // findMissingElements(new int[] {3, 2, 8, 4, 5}, new int[] {5, 7, 3, 0, 2}).ForEach(Console.WriteLine);


            // ~~~~~~ 01 - Dictionary and HashSet Operations ~~~~~~~
            /*Dictionary<int, Employee> employeeesById = new Dictionary<int, Employee>();
            // employeeesById.Add(employeeOne.id, employeeOne);
            // employeeesById.Add(employeeTwo.id, employeeTwo);
            // employeeesById.Add(employeeThree.id, employeeThree);

            // Employee e;
            // if(employeeesById.TryGetValue(9415, out e)){
            //     Console.WriteLine(e.name + " : " + e.department);
            // }

            // HashSet<string> productCodes = new HashSet<string>();
            // productCodes.Add("8F26B");
            // productCodes.Add("0A43P");
            // productCodes.Add("J2H762");

            // productCodes.Contains("48DB9");
            // productCodes.Contains("J2H762");
            */
            
        }

        // ~~~~~ 04 - Detect a Cyclic linked list ~~~~~
        

        // ~~~~~ 03 ~~~~~
        static void displayFreqOfEachElement(int[] arr){
            Dictionary<int, int> freqDictionary = new Dictionary<int, int>();
            for(int i = 0; i < arr.Length; i++)
            {
                if(freqDictionary.ContainsKey(arr[i])){
                    freqDictionary[arr[i]]++;
                }else{
                    freqDictionary[arr[i]] = 1;
                }
            }

            foreach(KeyValuePair<int, int> x in freqDictionary){
                Console.WriteLine(x.Key + " --> " + x.Value) ;
            }
        }


        // ~~~~ 02 ~~~~~
        static List<int> findMissingElements(int[] first, int[] second)
        {
            List<int> missingElement = new List<int>();
            HashSet<int> secondArrayItems = new HashSet<int>();

            foreach(int item in second){
                secondArrayItems.Add(item);
            }

            foreach(int item in first){
                if(!secondArrayItems.Contains(item)){
                    missingElement.Add(item);                }
            }
            
            return missingElement;

        }


    }

}