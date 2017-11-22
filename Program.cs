/************************************************
Name:       Leah  
Date:       11/22/2017
Project:    newCSharpFoundations
************************************************
*/


using System;

namespace newCSharpFoundations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter a number between 5 and 20");
            int input = int.Parse (Console.ReadLine());

            int i = 1;
            while (i <= input)
            {
                string test = (i % 2 == 0) ? " is even." : " is odd.";
                Console.WriteLine(i + test);     
                i++;
            }    


        }

    }
}
