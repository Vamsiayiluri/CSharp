using System;


namespace ConsoleApp15
{
    /// <summary>
    /// This product class have only one method getmaxproduct to find the largest four digit product
    /// </summary>
   
    public class Product
    {
        /// <summary>
        /// This method uses input and find the multiplication of individual digits of largest four digit 
        /// number 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public int GetMaxProduct(string input)
        {
            int maxProduct = 0;    
            
            //loop starts for first digit of the string and continues to iterate upto last 3 numbers of string
            for (int i = 0; i < input.Length - 3; i++)
            {
                int tempProduct = 1;

                //for each digit in string this loop finds product of the 4 numbers with next next 3 digits
                for (int j = 0; j < 4; j++)
                {
                    char k = input[i + j];
                    int val = (int)Char.GetNumericValue(k);
                    tempProduct *= val;
                }

                //here we will get the maximum product value
                if (tempProduct > maxProduct)
                {
                    maxProduct = tempProduct;
                }

            }

            return maxProduct;
        }

    }
}
