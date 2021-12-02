// See https://aka.ms/new-console-template for more information
// Jose O Hidalgo
// linkedin algorithm #1 + challenge ~~ String Algorithm. 
using System;
using System.Linq;
using System.Text;

namespace Algorithms
{
    class Program
    {

        static Boolean IsUpperCase(String s)
        {
            return s.All(char.IsUpper);
        }

        static Boolean IsLowerCase(String s)
        {
            return s.All(char.IsLower);
        }

        static Boolean isPasswordComplex(string s)
        {
            return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit);
        }
        static void Main(string[] args)
        {
            // ~~~~~~~~~~~ 05 ~~~~~~~~~~
            //      Challenge
            Console.WriteLine(ReverseSentence("Why is this not working :/"));


            // ~~~~~~~~~~~ 04 ~~~~~~~~~
            /* Console.WriteLine(ReverseTwo("Hello world"));
            // Console.WriteLine(ReverseTwo(""));
            // Console.WriteLine(ReverseTwo("Hello"));
            // Console.WriteLine(ReverseTwo(null));

            // Console.WriteLine(Reverse("Hello world"));
            // Console.WriteLine(Reverse(""));
            // Console.WriteLine(Reverse("Hello"));
            Console.WriteLine(Reverse(null));*/

            // ~~~~~ 03 ~~~~~~~
            //Console.WriteLine("Hello World".ToLower().Contains("ll"));
            /*ParseContents("Hello World!");
            string input = "HeLLo";
            Console.WriteLine(IsAtEvenIndex(input, 'L'));
            Console.WriteLine(IsAtEvenIndex(input, 'T'));
            Console.WriteLine(IsAtEvenIndex(input, 'H'));
            Console.WriteLine(IsAtEvenIndex("", 'H'));
            Console.WriteLine(IsAtEvenIndex(null, 'L'));*/


            // ~~~~~ 02 ~~~~~~~
            // Console.WriteLine(NormalizeString("  Hello There, Buddy      "));

            // ~~~~~ 01 ~~~~~~~
            /* Console.WriteLine("Hello World");
            // Console.WriteLine(IsUpperCase("hello"));
            // Console.WriteLine(IsUpperCase("HELLO"));

            // Console.WriteLine(IsLowerCase("hello"));
            // Console.WriteLine(IsLowerCase("HELLO"));

            // Console.WriteLine(isPasswordComplex("Hell0"));
            // Console.WriteLine(isPasswordComplex("Hello"));
            // Console.WriteLine(isPasswordComplex("HellO"));
            // Console.WriteLine(isPasswordComplex("Hell0"));
             Console.WriteLine(isPasswordComplex("hell0"));*/
        }

        static string ReverseSentence(string input)
        {
            String newSentense = "";
            if(string.IsNullOrEmpty(input))
            {
                return input;
            }

            String[] word = input.Split(' ');
            for(int i = 0; i < word.Length; i++)
            {
                //Console.WriteLine(Reverse(word[i]));
                word[i] = Reverse(word[i]);

                newSentense += word[i] + " ";
            }
            return newSentense;

        }

        static string ReverseTwo(String input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return input;
            }
            char[] arr = input.ToArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static string Reverse(String input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return input;
            }
            StringBuilder reversed = new StringBuilder(input.Length);
             for(int i = input.Length - 1; i>= 0; i--)
             {
                 reversed.Append(input[i]);
             }
             return reversed.ToString();
            
        }
        static Boolean IsAtEvenIndex(string s, char item)
        {
            if(string.IsNullOrEmpty(s))
            {
                return false;

            }

            for(int i = 0; i < s.Length / 2 + 1; i = i +2)
            {
                if(s[i] == item)
                {
                    return true;
                }
            }
            return false;
        }

        static void ParseContents(string s)
        {
            Console.WriteLine("Option 1");
            foreach(char c in s)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("Option 2");
            for(int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                Console.WriteLine(c);
            }

            Console.WriteLine("Option 3");

        }

        static string NormalizeString(String input)
        {
            return input.ToLower().Trim().Replace(",", "");
            // string lowercased = input.ToLower();
            // string trimmed = lowercased.Trim();
            // trimmed.Replace(",", "");
        }

    }
}
