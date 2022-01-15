using System;


namespace KataChallengesCSharp

{
    internal class Program
    {
        static void Main(string[] args)
        {

            Challenge2IsValidWalk chl2 = new Challenge2IsValidWalk();
            string[] w = { "n", "s" };
            Console.WriteLine(chl2.IsValidWalk(w));

        }
    }
}
