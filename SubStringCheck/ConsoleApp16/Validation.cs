using System;

namespace ConsoleApp16
{
    /// <summary>
    /// This validation class will only have a validation method to validate whether give input is valid or not
    /// </summary>
    public class Validation
    {
        /// <summary>
        /// This method checks whether the given input strings are valid or not
        /// </summary>
        /// <param name="string1"></param>
        /// <param name="string2"></param>
        /// <returns></returns>
        public bool Validate(string string1,string string2)
        {
            bool result = false;

            if(string1.Length<string2.Length)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }
    }
}
