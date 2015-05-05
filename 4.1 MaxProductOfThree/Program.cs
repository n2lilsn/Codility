using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1_MaxProductOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[6];
            //A[0] = -3;
            //A[1] = 1;
            //A[2] = 2;
            //A[3] = 6;
            //A[4] = 5;
            //A[5] = 6;

            A[0] = -3;
            A[1] = 1;
            A[2] = 2;
            A[3] = -2;
            A[4] = 5;
            A[5] = 6;

            Console.WriteLine(solution(A));
            Console.Read();
        }
        static int solution(int[] A)
        {
            List<int> tmp = A.ToList();
            Dictionary<int, int> trip = new Dictionary<int, int>();
            
            trip.Add(Array.LastIndexOf(A, tmp.Max()), tmp.Max());
            tmp.Remove(tmp.Max());

            for (int i = 1; i < 3; i++)
            {
                if (trip.Count() == 1)
                {
                    int t = Array.IndexOf(A, tmp.Max());
                    trip.Add(t, tmp.Max());
                    tmp.Remove(tmp.Max());
                }
                else
                {
                    do
                    {
                        int t = Array.IndexOf(A, tmp.Max());
                        trip.Add(t, tmp.Max());
                        tmp.Remove(tmp.Max());
                    } while (trip.Keys.ElementAt(i - 1) < trip.Keys.ElementAt(i) && trip.Count < 3);
                }
            }

            return trip.Values.ElementAt(0)*
                   trip.Values.ElementAt(1)*
                   trip.Values.ElementAt(2);
        }
    }
}
