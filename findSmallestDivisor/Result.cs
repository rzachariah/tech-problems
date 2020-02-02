using System;
using System.Linq;
using System.Text;

namespace findSmallestDivisor
{
    public class Result
    {
        /*
         * Complete the 'findSmallestDivisor' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. STRING s
         *  2. STRING t
         */
        public static int findSmallestDivisor(string s, string t)
        {
            if (!isDivisibleBy(s, t)) return -1;

            var found = false;
            string candidate = string.Empty;
            for (int candidateSize = 1; candidateSize <= t.Length && !found; candidateSize++)
            {
                candidate = t.Substring(0, candidateSize);
                if (isDivisibleBy(t, candidate))
                {
                    found = true;
                }
            }
            return found
                ? candidate.Length
                : t.Length;
        }

        private static bool isDivisibleBy(string subject, string candidate)
        {
            if (subject.Length < candidate.Length) return false;
            if (candidate.Length == 0) return false;
            if (subject.Length % candidate.Length != 0) return false;

            var factor = subject.Length / candidate.Length;

            var tRepeated = Enumerable.Repeat(candidate, factor)
                .Aggregate(new StringBuilder(), (acc, next) =>
                {
                    acc.Append(next);
                    return acc;
                })
                .ToString();

            return subject == tRepeated;
        }
    }
}
