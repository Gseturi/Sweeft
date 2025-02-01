using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweeftProblems
{
    internal static class Problems
    {

        public static bool sPalindrome(string text)
        {
            if (text == null) return false;
            if (text.Length == 0) return false;


            int right = text.Length - 1;
            int left = 0;
            while (left < right)
            {
                while (right > left && !char.IsLetterOrDigit(text[left])) left++;
                while (right > left && !char.IsLetterOrDigit(text[right])) right--;



                if (char.ToLower(text[left]) != char.ToLower(text[right])) return false;


                left++;
                right--;
            }


            return true;

        }


        public static int MinSplit(int amount)
        {
           if(amount == 0) return 0;

            int[] coins = { 50, 20, 10, 5, 1 };
            int counter = 0;
          

            foreach (int i in coins)
            {
                counter += (int)amount / i;
                amount = amount % i;


            }
            return counter;
        }




        public static int NotContains(int[] array)
        {
            Array.Sort(array);
            int smallest = 1;
            foreach (int i in array)
            {
                if (i == smallest)
                {

                    smallest++;
                }
               
            }


            return smallest;
        }


        public static bool IsProperly(string sequence)
        {
            int decider = 0;
            foreach(char a in sequence)
            {

                if(a == '(')
                {
                    decider++;
                }
                if(a == ')')
                {
                    decider--;
                }
                if (decider < 0)
                {
                    return false;
                }

            }
            if(decider==0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public static int CountVariants(int stairCount)
        {
            return CountVariantsRecursion(stairCount);
        }


        private static int CountVariantsRecursion(int stairCount)
        {
            if (stairCount == 0) return 1;
            if (stairCount == 1) return 1;



            return CountVariantsRecursion(stairCount - 1) + CountVariantsRecursion(stairCount - 2);
        }

    }
}


