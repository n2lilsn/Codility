using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2._3_MissingInteger;

namespace Testy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MissingInteger()
        {
            var calc = new Program();

            int[] A = new int[6];
            int[] B = new int[6];
            int[] C = new int[1];
            A[0] = 1;
            A[1] = 3;
            A[2] = 6;
            A[3] = 4;
            A[4] = 1;
            A[5] = 2;

            C[0] = 3;

            int sol = Program.solution(C);
            Assert.AreEqual(2, sol);
        }
    }
}
