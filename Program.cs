/************************************************
Name:       Leah  
Date:       11/28/2017
Project:    newCSharpFoundations
************************************************
*/


using System;
using System.Text;

namespace newCSharpFoundations
{

    class Program
    {
        static void Main(string[] args)
        {
            int pair1 = MultiplyTwoNumbers(2, 4);
            MyMath mathInstance = new MyMath();
            int pair2 = mathInstance.MultiplyTwoNumbers(16, 12);
            int pair3 = (pair1 * pair2);
            Console.WriteLine(pair3);
        }
        static int MultiplyTwoNumbers(int firstNumber, int secondNumber)
        {
            int prod = (firstNumber * secondNumber);
            return prod;
        }

    }
    class MyMath
    {
        public int MultiplyTwoNumbers(int firstNumber, int secondNumber)
        {
            int prod = (firstNumber * secondNumber);
            return prod;
        }
    }
}
