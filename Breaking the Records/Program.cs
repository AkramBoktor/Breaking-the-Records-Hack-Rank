using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breaking_the_Records
{
    class Program
    {
        /*
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

        public static List<int> breakingRecords(List<int> scores)
        {
            List<int> result = new List<int>();
            int maxScore = scores[0];
            int minScore = scores[0];
            int countMax = 0;
            int countMin = 0;

            foreach (var score in scores)
            {
                if(maxScore < score)
                {
                    maxScore = score;
                    countMax++;
                }

                if(minScore > score)
                {
                    minScore = score;
                    countMin++;
                }
            }

            result.Add(countMax);
            result.Add(countMin);
            return result;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

            List<int> result = Program.breakingRecords(scores);

            Console.WriteLine(String.Join(" ", result));

         
        }
    }

}