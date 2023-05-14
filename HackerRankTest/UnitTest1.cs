using System.Diagnostics;
using HackerRank_Sample;

namespace HackerRankTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void MinimumMovesTest()
        {
            var arr1 = new List<int>() { 123, 543 };
            var arr2 = new List<int>() { 321, 279 };
            var actual = HackerRank_Sample.SampleTest.minimumMoves(arr1, arr2);
            Assert.AreEqual(16, actual);

            arr1 = new List<int>() { 1234, 4321 };
            arr2 = new List<int>() { 2345, 3214 };
            actual = HackerRank_Sample.SampleTest.minimumMoves(arr1, arr2);
            Assert.AreEqual(10, actual);
        }

        [TestMethod]
        public void ComputeMovesToMatchTest()
        {
            var modify = new List<int>() {1,2,3};
            var match = new List<int>() {3,2,1};
            var actual = HackerRank_Sample.SampleTest.ComputeMovesToMatch(modify, match);
            Assert.AreEqual(4, actual);

            modify = new List<int>() { 5, 4, 3 };
            match = new List<int>() { 2, 7, 9 };
            actual = HackerRank_Sample.SampleTest.ComputeMovesToMatch(modify, match);
            Assert.AreEqual(12, actual);

            modify = new List<int>() { 1, 2, 3, 4 };
            match = new List<int>() { 2, 3, 4, 5 };
            actual = HackerRank_Sample.SampleTest.ComputeMovesToMatch(modify, match);
            Assert.AreEqual(4, actual);

            modify = new List<int>() { 4, 3, 2, 1 };
            match = new List<int>() { 3, 2, 1, 4 };
            actual = HackerRank_Sample.SampleTest.ComputeMovesToMatch(modify, match);
            Assert.AreEqual(6, actual);


        }
        
        [DataTestMethod]
        [DataRow(4, "0,1,1,2")]
        [DataRow(10, "0,1,1,2,3,5,8,13,21,34")]
        [DataRow(1, "0")]
        [DataRow(2, "0,1")]
        [DataRow(3, "0,1,1")]
        public void FibonacciTest(int count, string expected)
        {
            var actual = HackerRank_Sample.SampleTest.fibonacci(count);
            Assert.AreEqual(expected, String.Join(',', actual));
        }
        

        
        [TestMethod]
        public void SampleTest()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                Sample.fizzBuzz(15);
                string expected = "1\r\n2\r\nFizz\r\n4\r\nBuzz\r\nFizz\r\n7\r\n8" +
                    "\r\nFizz\r\nBuzz\r\n11\r\nFizz\r\n13\r\n14\r\nFizzBuzz";

                Assert.AreEqual(expected, sw.ToString().Trim());
            }

        }
        
    }
}