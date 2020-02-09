using System;
using System.Collections.Generic;
using System.Linq;

namespace minSum
{
    public class Iteration2
    {
        /// <summary>
        /// Start by sorting list in descending order O(nlogn)
        ///
        /// Then for each of k iterations
        /// - remove first item O(1)
        /// - calc replacenent O(1_
        /// - insert replacenent back in list in sorted order O(n)
        ///
        /// Then sum O(n)
        ///
        /// Total runtime is O(kn)
        /// </summary>
        /// <param name="num"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int minSum(List<int> num, int k)
        {
            num.Sort();
            num.Reverse();
            while (k-- > 0)
            {
                var max = num[0];
                num.RemoveAt(0);
                var replacement = (int)Math.Ceiling(max / 2m);
                var inserted = false;
                var i = 0;
                while (!inserted)
                {
                    if (i == num.Count() || replacement > num[i])
                    {
                        num.Insert(i, replacement);
                        inserted = true;
                    }
                    i++;
                }
            }
            return num.Sum();
        }
    }
}
