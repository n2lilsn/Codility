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
            int[] B = new int[2];
            int[] C = new int[7];
            int[] D = new int[200];

            A[0] = 1;
            A[1] = 3;
            A[2] = 6;
            A[3] = 4;
            A[4] = 1;
            A[5] = 2;

            B[0] = int.MinValue;
            B[1] = int.MaxValue;

            C[0] = -3;
            C[1] = -2;
            C[2] = -1;
            C[3] = 0;
            C[4] = 1;
            C[5] = 2;
            C[6] = 3;

            for (int i = 0; i < 200; i++)
            {
                if (i != 101)
                    D[i] = i;
            }

            int solA = Program.solution(A);
            int solB = Program.solution(B);
            int solC = Program.solution(C);
            int solD = Program.solution(D);

            Assert.AreEqual(5, solA);
            Assert.AreEqual(1, solB);
            Assert.AreEqual(4, solC);
            Assert.AreEqual(101, solD);

        }
    }
}
