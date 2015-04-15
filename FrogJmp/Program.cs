using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogJmp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(solution(10,85,30));
            Console.Read();
        }
        static int solution(int X, int Y, int D)
        {
            int count = ((Y - X) / D);
            if (((Y - X) % D) > 0)
                count++;
            return count;
        }
    }
}
