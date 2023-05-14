using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace HackerRank_Sample
{
    public static class SampleTest
    {

        public static int minimumMoves(List<int> arr1, List<int> arr2)
        {
            return ComputeMoves(arr1, arr2);
        }

        public static int ComputeMoves(IEnumerable<int> modifyList, IEnumerable<int> matchList)
        {
            if (!modifyList.Any())
            {
                return 0;
            }

            var modify = BreakUpNumber(modifyList.ElementAt<int>(0));
            var match = BreakUpNumber(matchList.ElementAt<int>(0));

            var moves = ComputeMovesToMatch(modify, match);

            return moves + ComputeMoves(modifyList.Skip(1), matchList.Skip(1));
        }

        public static int ComputeMovesToMatch(IEnumerable<int> modify, IEnumerable<int> match)
        {
            var totalMoves = 0;
            for (var index = 0; index < modify.Count(); index++)
            {
                totalMoves += Math.Abs(modify.ElementAt(index) - match.ElementAt(index));
            }
            return totalMoves;
        }

        private static IEnumerable<int> BreakUpNumber(int num)
        {
            var numText = $"{num}";
            return numText.Select(n => ((int)Char.GetNumericValue(n)));
        }



        public static List<int> fibonacci(int n)
        {
            var result = new List<int>(n);
            ComputeFibonacci(0, result);
            return result;
        }

        private static void ComputeFibonacci(int index, List<int> result)
        {
            if (index == result.Capacity)
            {
                return;
            }

            var nextValue = (index == 0 || index == 1) ? index : result[index - 2] + result[index - 1];
            result.Add(nextValue);
            ComputeFibonacci(index + 1, result);
        }
    }
}
