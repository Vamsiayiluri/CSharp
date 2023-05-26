using System;


namespace ConsoleApp15
{
    public class Validation
    {
        /// <summary>
        /// This method will check whether the input string is valid or not.i.e,it checks whether string has
        /// minimum four digits or not
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool Validate(string input)
        {
            bool result;

            //If length of given input is less than 4,then the input is invalid
            if(input.Length < 4)
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
