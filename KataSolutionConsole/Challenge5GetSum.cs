namespace KataChallengesCSharp

{
    public class Challenge5GetSum
    {

        /*Given two integers a and b, which can be positive or negative, find the sum of all the integers between and 
         * including them and return it. If the two numbers are equal return a or b.Note: a and b are not ordered!
         */
        public int GetSum(int a, int b)
        {
            //Good Luck!
            int sum = 0;
            if (a > b)
            {
                int c = a;
                a = b;
                b = c;
                for (int i = a; i <= b; i++)
                {
                    sum = sum + i;
                }
                return sum;
            }

            for (int i = a; i <= b; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}
