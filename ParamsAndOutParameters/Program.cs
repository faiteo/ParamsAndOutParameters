using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsAndOutParameters
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] myArray1 = new int[5] { 10, 8, 4, 12, 5 };

            int[] myArray2 = { 9, 3, 6, 1, 2 };

            int[] myArray3 = new int[6];
            myArray3[0] = 12;
            myArray3[1] = 5;
            myArray3[2] = 10;
            myArray3[3] = 2;
            myArray3[4] = 1;
            myArray3[5] = 8;



            //Call by passing multiple values seperated by comma
            int sum7 = MethodDefinitions.SumArrayForLoop(7, 3, 4, 6);
            Console.WriteLine("result of sum7 is:  {0}", sum7);
            int sum8 = MethodDefinitions.SumArrayForEachLoop(2, 4, 6, 5, 7);
            Console.WriteLine("result of sum8 is:  {0}", sum8);
            Console.WriteLine("------------------------");

            //Call with no parameter
            int sum9 = MethodDefinitions.SumArrayForLoop();
            Console.WriteLine("result of sum9 is:  {0}", sum9);
            int sum10 = MethodDefinitions.SumArrayForEachLoop();
            Console.WriteLine("result of sum10 is:  {0}", sum10);
            Console.WriteLine("------------------------");


            //Call with a single parameter
            int sum11 = MethodDefinitions.SumArrayForEachLoop(2);
            Console.WriteLine("result of sum11 is:  {0}", sum11);
            Console.WriteLine("------------------------");


            //Call by passing a predefined array
            int sum1 = MethodDefinitions.SumArrayForLoop(myArray1);
            Console.WriteLine("result of sum1 is: {0}", sum1);
            int sum2 = MethodDefinitions.SumArrayForEachLoop(myArray1);
            Console.WriteLine("result of sum2 is:  {0}", sum2);
            Console.WriteLine("------------------------");


            //Call by passing a predefined array
            int sum3 = MethodDefinitions.SumArrayForLoop(myArray2);
            Console.WriteLine("result of sum3 is:  {0}", sum3);
            int sum4 = MethodDefinitions.SumArrayForEachLoop(myArray2);
            Console.WriteLine("result of sum4 is:  {0}", sum4);
            Console.WriteLine("------------------------");



            //Call by passing a predefined array
            int sum5 = MethodDefinitions.SumArrayForLoop(myArray3);
            Console.WriteLine("result of sum5 is:  {0}", sum5);
            int sum6 = MethodDefinitions.SumArrayForEachLoop(myArray3);
            Console.WriteLine("result of sum6 is:  {0}", sum6);
            Console.WriteLine("--------------------------------------------");

            //returns a count of the numbers that are greater or equal to 5 in myArray3 
            int result = myArray3.Count(x=>x > 5);
            Console.WriteLine("{0} numbers are greater than 5 in myArray3", result);
            Console.WriteLine("--------------------------------------------");

            //returns the total number of elements in myArray1
            int result1 = myArray1.Count();
            Console.WriteLine("The total number of elements in myArray1 is {0}", result1);
            Console.WriteLine("--------------------------------------------");
    

            //Test Out parameter with TryParse 
            MethodDefinitions.ValidateNumber("45");
            Console.WriteLine("--------------------------------------------");


            //Test OutParameter with multiple results from a single function
            int add;
            int minus;
            int multiply;
            MethodDefinitions.Calculate_Sum_Prod_Sub(4, 5, out add, out multiply, out minus);

            Console.WriteLine("The result of addition is: {0} ", add);
            Console.WriteLine("The result of subtraction is: {0} ", minus);
            Console.WriteLine("The result of multiplication is: {0} ", multiply);
            Console.WriteLine("--------------------------------------------");


            Console.ReadLine();



        }
    }
}
