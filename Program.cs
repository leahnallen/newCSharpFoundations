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
            //string[] names = new string[] { "Sansa", "Bran", "Eddard", "Arya"};
            string[] people = new string[4];
            people[0] = "Sansa";
            people[1] = "Bran";
            people[2] = "Eddard";
            people[3] = "Arya";

        foreach(string person in people) {
            Console.WriteLine(person);
        }
        }


    }
}
