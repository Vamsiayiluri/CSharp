using System;
using System.Collections.Generic;

namespace ConsoleApp16
{
    /// <summary>
    /// this progam class will only have a main method where input is given and program logic reference is given
    /// </summary>

    public class Program
    {
        /// <summary>
        /// Main method will only have input strings and object creation for program logic and at last it returns the output
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter string 1");
            string string1 = Console.ReadLine();
            Console.WriteLine("Enter string 2");
            string string2 = Console.ReadLine();
            List<int> indexes = new List<int>();

            Validation valid = new Validation();
            bool res = valid.Validate(string1, string2);

            //if validation of input is true this if block will execute
            if(res) 
            {               
                ProgramLogic findSubstring = new ProgramLogic();
                int count = findSubstring.SubStringCount(string1, string2, ref indexes);

                Result output = new Result();
                output.Display(count, indexes);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
