using System;
using System.Collections.Generic;
using System.Linq;

namespace minSum
{
    public class Iteration1
    {
        /// <summary>
        /// Same as Iteration0, expressed in sexier fluent syntax with LINQ
        /// </summary>
        /// <param name="num"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int minSum(List<int> num, int k)
        {
            return Enumerable.Range(0, k)
                .Aggregate(num.ToList(), (acc, _) =>
                {
                    var max = acc.Max();
                    acc.Remove(max);
                    var replacement = (int)Math.Ceiling(max / 2m);
                    acc.Add(replacement);
                    return acc;
                })
                .Sum();
        }
    }
}
