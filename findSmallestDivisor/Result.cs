using System.Linq;

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

        private static bool isDivisibleBy(string dividend, string divisor)
        {
            if (dividend.Length < divisor.Length) return false;
            if (divisor.Length == 0) return false;
            if (dividend.Length % divisor.Length != 0) return false;

            var factor = dividend.Length / divisor.Length;

            return Enumerable.Range(0, factor)
                .Aggregate(true, (acc, segmentIndex) =>
                {
                    if (!acc) return false;
                    var start = segmentIndex * divisor.Length;
                    return isPartialMatch(dividend, divisor, start);
                });
        }

        private static bool isPartialMatch(string subject, string candidate, int start)
        {
            var segment = subject.Substring(start, candidate.Length);
            return segment == candidate;
        }
    }
}
