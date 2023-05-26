using System;

namespace ConsoleApp15
{
    
    public class Program
    {
        /// <summary>
        /// Main method return will take the input and show the output by calling getMaxProduct methods
        /// </summary>
        /// <param name="args"></param>
        public static void Main()
        {
            Console.WriteLine("Enter a number  greater than 999 ");
            string input = Console.ReadLine();    
            
            Validation valid = new Validation();
            bool result = valid.Validate(input);

            //if result is true the number will have 4 or more digits so we can go and find the max product 
            if(result)
            {
                Product product = new Product();
                int maxProduct = product.GetMaxProduct(input);
                Console.WriteLine($"maxProduct is : {maxProduct} ");
            }
            //if result is false the input given is invalid
            else
            {
                Console.WriteLine("invalid input");
            }           
        }
        
    }
}
