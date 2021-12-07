using System.Collections.Generic;

namespace Iterator
{
    public class Fibonacci
    {
        public static IEnumerable<int> GenerateFibonacci(int count)
        {
            int prev = 0;
            int current = 1;
            while (count -- > 0)
            {
                yield return current;

                int tmp = current;
                current = prev + current;
                prev = tmp;
            }
        }
    }
}
