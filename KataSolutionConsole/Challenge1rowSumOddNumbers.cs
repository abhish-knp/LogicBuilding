namespace KataChallengesCSharp
{
    public class Challenge1rowSumOddNumbers
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

        }
    }
}
