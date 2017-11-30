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
            int? retValue = Parser.ParseInt("GOT");
            if (retValue != null)
            {
                Console.WriteLine(retValue);
            }
            else
            {
                Console.WriteLine("Null returned");
            }
        }

    }
    class Parser
    {
        public static int? ParseInt(string enterValue)
        {
            int parsedInt;
            if (int.TryParse(enterValue, out parsedInt))
            {
                return parsedInt;
            }
            else
            {
                return null;
            }
        }

    }



}
