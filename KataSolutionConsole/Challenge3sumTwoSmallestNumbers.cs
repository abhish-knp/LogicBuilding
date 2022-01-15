using System;


namespace KataChallengesCSharp

{
    public class Challenge3sumTwoSmallestNumbers
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
            Array.Sort(numbers);


            // sort the array 
            // do sum of least two index, last two elements


            return l;
        }
    }
}
