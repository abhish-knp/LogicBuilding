namespace KataChallengesCSharp

{
    public class Challenge2IsValidWalk
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
}
