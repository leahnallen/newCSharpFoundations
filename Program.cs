/************************************************
Name:       Leah  
Date:       11/22/2017
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
             Console.WriteLine("Please, enter your name:");
            string userName = Console.ReadLine();
            StringBuilder newName = new StringBuilder(userName);
            newName.Insert(0,"Hello ");

            Console.WriteLine(newName.ToString());
            Console.WriteLine("Please, press any key to close.");
            Console.ReadKey();

        }

    }
}
