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
            string gameOfThronesPremier = "April 17, 2011";
            DateTime gameOfThronesPremierDate = Convert.ToDateTime(gameOfThronesPremier);
            Console.WriteLine(gameOfThronesPremierDate);
        }
    }
}
