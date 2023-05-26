using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    /// <summary>
    /// This result class have only one method to display the result
    /// </summary>
    public class Result
    {
        /// <summary>
        /// this meethod will show output of number of times substring occurs and index positions of substring
        /// </summary>
        /// <param name="count"></param>
        /// <param name="indexes"></param>
        public void Display(int count,List<int> indexes)
        {
            Console.WriteLine($"Number of times occurred: {count}");
            Console.WriteLine($"Index Positions: ");

            if (indexes.Count == 0)
            {
                Console.Write("NULL");
            }
            else
            {
                for (int i = 0; i < indexes.Count; i++)
                {
                    Console.Write(indexes[i] + " ");
                }
            }
        }

        
    }
}
