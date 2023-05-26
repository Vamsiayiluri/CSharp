using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    /// <summary>
    /// this class only have a method to check for substrings of main string with the second string
    /// </summary>
    public class ProgramLogic
    {
        /// <summary>
        /// this method will find the number of times a substring occurs in the main string and also
        /// find the indexes where substring occurs in the main string
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="indexes"></param>
        /// <returns></returns>
        public int SubStringCount(string s1, string s2, ref List<int> indexes)
        {
            int count = 0;
            
            //this for loop starting with first letter of string and iterates upto the difference of lengths between strings
            //main function is it checks whether the substring of the main string is equal to given string and if yes increases count by one and add index to list
            for (int i = 0; i <= s1.Length - s2.Length; i++)
            {
                if (s1.Substring(i, s2.Length) == s2)
                {
                    count++;
                    indexes.Add(i);
                }
            }

            return count;
        }
    }
}
