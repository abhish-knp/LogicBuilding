using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicBuildForChallenge1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Message");
            // Challenge 3

            Challenge3 chl3 = new Challenge3();
            int [] x = { 1, 2, 3 , 4};
            var result = chl3.sumTwoSmallestNumbers(x); 
            Console.WriteLine(result);    


            // Challenge 2 
            {
                Challenge1 chl1 = new Challenge1();
                //var result = chl1.rowSumOddNumbers(4);
                Console.WriteLine(result);
            }
             
            //Challenge 1
            {
                Challenge2 chl2 = new Challenge2();
                string[] w = { "n", "s" };
                //var result = chl2.IsValidWalk(w);
                Console.WriteLine(result);
            }
           
        }
    }
    public class Challenge1
    {
        public long rowSumOddNumbers(long n)
        {
            // TODO

            long sum = 0;
            long result = 0;
            for (long i = 0; i <= n; i++)
            {
                sum = i + sum;
            }
            for (long j = (sum * 2 - n * 2); j <= sum * 2; j++)
            {
                if (j % 2 != 0)
                {
                    result = result + j;
                }
            }
            return result;

            // sum of n = m; 
            // for(i = m-n*2, i<= m*2, i++)
            // {if (odd): sum+=i} => return

        }
    }

    public class Challenge2
    {
        public bool IsValidWalk(string[] walk)
        {
            int Vert = 0;
            int Horz = 0;
            foreach (string wi in walk)
            {
                if (wi == "n")
                {
                    Vert++;
                }
                else if (wi == "s")
                {
                    Vert--;
                }
                else if (wi == "e")
                {
                    Horz++;
                }
                else if (wi == "w")
                {
                    Horz--;
                }


            }

            if ((walk.Length == 10) && (Vert == 0 && Horz == 0))
            {
                return true;
            }
            else { return false; }

        }
    }

    public class Challenge3
    {
        /*Create a function that returns the sum of the two lowest positive numbers given an array of minimum 4 positive integers. 
         * No floats or non-positive integers will be passed.
         * For example, when an array is passed like [19, 5, 42, 2, 77], the output should be 7.
         * [10, 343445353, 3453445, 3453545353453] should return 3453455
         */
        public int sumTwoSmallestNumbers(int[] numbers)
        {
            //Code here...
            var l = numbers.Length;
            var list = numbers;
            // sort the array 
            // do sum of least two index, last two elements


            return l;
        }
    }

    public class Challenge4
    {
        /*Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence, 
         * which is the number of times you must multiply the digits in num until you reach a single digit.For example (Input --> Output):
         * 39 --> 3 (because 3*9 = 27, 2*7 = 14, 1*4 = 4 and 4 has only one digit)
         * 999 --> 4 (because 9*9*9 = 729, 7*2*9 = 126, 1*2*6 = 12, and finally 1*2 = 2)
         * 4 --> 0 (because 4 is already a one-digit number)
        */

        public int Persistence(long n)
        {
            // your code
            return 10;
            // To convert into string and split and convert to int
            // for (i, length, i++) ; prod = prod*i;
            // while length will be 1
        }
    }
}
