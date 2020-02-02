using System;
using System.Collections.Generic;
using System.Linq;

namespace minSum
{
    public class Result
    {
        /*
         * Complete the 'minSum' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY num
         *  2. INTEGER k
         */
        public static int minSum(List<int> num, int k)
        {
            var hashMap = new Dictionary<int, List<int>>();
            foreach (int value in num)
            {
                var hash = getHash(value);
                addToMap(hashMap, hash, value);
            }

            for (int h = hashMap.Keys.Max(); h > 0 && k > 0; h--)
            {
                var maxList = hashMap[h];
                maxList.Sort((x, y) => y.CompareTo(x));
                var i = 0;
                while (i < maxList.Count && k > 0)
                {
                    var maxItem = maxList[i];
                    var replacement = (int) Math.Ceiling(maxItem / 2m);
                    var replacementHash = h - 1;
                    addToMap(hashMap, replacementHash, replacement);
                    i++;
                    k--;
                }

                if (i == maxList.Count)
                {
                    hashMap.Remove(h);
                }
                else
                {
                    var remainder = maxList.GetRange(i, maxList.Count - i);
                    hashMap[h] = remainder;
                }
            }

            return hashMap
                .Values
                .SelectMany(l => l)
                .Sum();
        }

        private static void addToMap(IDictionary<int, List<int>> hashMap, int hash, int value)
        {
            if (!hashMap.ContainsKey(hash))
            {
                hashMap[hash] = new List<int>();
            }

            hashMap[hash].Add(value);
        }

        private static int getHash(int value)
        {
            return (int) Math.Ceiling(Math.Log(value, 2));
        }
    }
}