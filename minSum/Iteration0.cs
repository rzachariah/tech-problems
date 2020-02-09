using System;
using System.Collections.Generic;
using System.Linq;

namespace minSum
{
    public class Iteration0
    {
        /// <summary>
        /// Perform the following procedure k times
        /// - find max in list    O(n)
        /// - remove it           O(n)
        /// - calc replacement    O(1)
        /// - add replacement     O(1)
        /// -
        /// Finally, sum the list O(n)
        ///
        /// Total runtime is O(kn)
        /// </summary>
        /// <param name="num"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int minSum(List<int> num, int k)
        {
            while (k-- > 0)
            {
                var max = num.Max();
                var replacement = (int)Math.Ceiling(max / 2m);
                num.Remove(max);
                num.Add(replacement);
            }
            return num.Sum();
        }
    }
}
