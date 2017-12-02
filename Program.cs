/************************************************
Name:       Leah  
Date:       11/28/2017
Project:    newCSharpFoundations
************************************************
*/


using System;
using System.Collections.Generic;
using System.Text;

namespace newCSharpFoundations
{

    class Program
    {
        static void Main(string[] args)
        {
            string[] GOTChars = { "Daenerys Targaryen", "Jon Snow", "Cersei Lannister", "Arya Stark", "Joffrey Baratheon", "Sansa Stark" };
            StarkJumper sj = new StarkJumper();
            string[] noStarks = sj.removeStarks(GOTChars);
                    
            foreach (string ch in noStarks)
            {
                System.Console.WriteLine(ch);
            }
        }
    }

    class StarkJumper
    {
        List<string> tempList = new List<string>();

        public string[] removeStarks(string[] GOTChars)
        {
            foreach (string ch in GOTChars)
            {
                string lastName = ch.Substring(ch.Length -5);

                if (lastName != "Stark")
                {
                    tempList.Add(ch);
                }
                
            }

            string[] retArray = tempList.ToArray();

            return retArray;
        }
    }
}