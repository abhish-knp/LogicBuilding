using NUnit.Framework;

namespace KataChallengesCSharp.Tests
{
    [TestFixture()]
    public class Challenge1Tests
    {
        
        [Test()]
        public void DirectionTests()
        {
            var chl1 = new Challenge1rowSumOddNumbers();
            long p = chl1.rowSumOddNumbers(1235);

            Assert.Fail();
        }
        

    }
    
}

