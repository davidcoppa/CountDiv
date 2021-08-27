using System;

namespace CountDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            //A = 6, B = 11 and K = 2
            Console.WriteLine("expected: 3 -"+s.solution(6, 11, 2));
            Console.WriteLine("expected: 20 -" + s.solution(11, 345, 17));
            Console.WriteLine("expected: 1 -" + s.solution(0, 0, 11));
            Console.WriteLine("expected: 0 -" + s.solution(1, 1, 11));
            Console.WriteLine("expected: 1 -" + s.solution(10, 10, 5));
            Console.WriteLine("expected: 0 -" + s.solution(10, 10, 7));
            Console.WriteLine("expected: 0 -" + s.solution(10, 10, 20));
            Console.WriteLine("expected: 249 -" + s.solution(6, 1000, 4));
            Console.WriteLine("expected: 61499951 -" + s.solution(100, 123000000, 2));
            Console.WriteLine("expected: 1230 -" + s.solution(101, 123000000, 100000));
            Console.WriteLine("expected: 1073741824 -" + s.solution(0, Int32.MaxValue, 2));
            Console.WriteLine("expected: " + Int32.MaxValue + " -" + s.solution(0, Int32.MaxValue, 1));

        }
    }
}
