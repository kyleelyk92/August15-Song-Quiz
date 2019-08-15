using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizConsoleApp;
namespace UnitTest
{
    [TestClass]
    public class ConsoleQuestionTests
    {
        [TestMethod]
        public void FirstNonRepeatingNumberTest()
        {
            var testArr = new int[] { 1, 2, 3, 4, 4, 5 }; // should be 4
            var myAns = Program.FirstNonRepeatingNumber(testArr);
            Assert.IsTrue(myAns == 4);
        }

        [TestMethod]
        public void CheckForDuplicatesTest()
        {
            var testArr = new int[] { 1, 2, 3, 4, 4, 5 }; // should be 4
            bool myBool = Program.CheckForDuplicates(testArr);

            Assert.IsTrue(myBool);
        }
    }
}
