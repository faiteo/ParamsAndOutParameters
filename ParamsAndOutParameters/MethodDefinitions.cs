using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsAndOutParameters
{
    public static class MethodDefinitions
    {
        public static int SumArrayForLoop(params int[] input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            return sum;
        }


        public static int SumArrayForEachLoop(params int[] input)
        {
            int sum = 0;
            foreach (int item in input)
            {
                sum += item;
            }
            return sum;
        }

        //Using Out Parameter to return multiple results from a single method
        public static void Calculate_Sum_Prod_Sub(int firstInput, int secondInput, out int sum, out int product, out int subtraction)
        {
            sum = firstInput + secondInput;
            product = firstInput * secondInput;
            subtraction = firstInput - secondInput;
        }

        //Out Parameter using TryParse method
        public static void ValidateNumber(string input)
        {
           
            int successfulConversion;
            //bool result = int.TryParse(input, out successfulConversion);
            if (int.TryParse(input, out successfulConversion))
            {
                Console.WriteLine("The input {0} is a valid number ", successfulConversion);
            }
            else
            {
                Console.WriteLine("Please enter a valid input for conversion");
            }
            
                
            
                
        }
    }
}
