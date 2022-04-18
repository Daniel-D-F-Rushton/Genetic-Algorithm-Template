using System;
using System.Collections.Generic;
using System.Text;

namespace Genetic_Algorithm_Template
{
    public class R55 : IProblem
    {
        /// <summary>
        /// This is a GA to test R55 = 43?
        /// It takes a string of 903 binary and checks to see how many collections of five mutual friends,
        /// or five mutual strangers exists. 
        /// IE AB, AC, AD, AE, BC, BD, BE, CD, CE, DE == 0
        /// OR AB, AC, AD, AE, BC, BD, BE, CD, CE, DE == 1
        /// 
        /// The intention of the Genetic algorithm is to find a zero error condition providing a counter proof
        /// to the conjecture that Ramsey 5,5 = 43
        /// It is presumed that no such correct answer exists.
        /// 
        /// This is a bit wasteful as there are a lot of mutations disregarded... but as it is only for an example
        /// I am not going to worry about it too much.
        /// 
        /// </summary>
        public int GeneSize { get; set; } = 1849;

        public string cheat()
        {
            return "1001111110010100100000000100101001111110011010011111100101001000000001001010011111100100100111111001010010000000010010100111111000001001111110010100100000000100101001111110000010011111100101001000000001001010011111100000100111111001010010000000010010100111110000001001111110010100100000000100101001111000000010011111100101001000000001001010011100000000100111111001010010000000010010100110000000001001111110010100100000000100101001000000000010011111100101001000000001001010000000000000100111111001010010000000010010100000000000001001111110010100100000000100101000000000000010011111100101001000000001001000000000000000100111111001010010000000010010000000000000001001111110010100100000000100000000000000000010011111100101001000000001000000000000000000100111111001010010000000010000000000000000001001111110010100100000000000000000000000000010011111100101001000000000000000000000000000100111111001010010000000000000000000000000001001111110010100100000000000000000000000000010011111100101001000000000000000000000000000100111111001010010000000000000000000000000001001111110010100100000000000000000000000000010011111100101001000000000000000000000000000100111111001010010000000000000000000000000001001111110010100000000000000000000000000000010011111100101000000000000000000000000000000100111111001010000000000000000000000000000001001111110010000000000000000000000000000000010011111100100000000000000000000000000000000100111111000000000000000000000000000000000001001111110000000000000000000000000000000000010011111100000000000000000000000000000000000100111110000000000000000000000000000000000001001111000000000000000000000000000000000000010011100000000000000000000000000000000000000100110000000000000000000000000000000000000001001000000000000000000000000000000000000000010000000000000000000000000000000000000000000100000000000000000000000000000000000000000001";
        }

        public int CalculateErrors(ref string geneString)
        {
            string holder = "0000000000000000000000000000000000000000000000000000000000000000000000000000";
            List<string> modded = new();
            
            for (int i = 0; i < 43; i++)
            {
                modded.Add(holder.Substring(0, i) + geneString.Substring(i * 43 + i, 43 - i));
            }
            geneString = "";
            for (int i = 0; i < modded.Count; i++)
            {
                geneString += modded[i];
            }

            int Worth = 0;
            for (int a = 0; a < 39; a++)
            {
                for (int b = a + 1; b < 40; b++)
                {
                    char comp = geneString[b + (a-1) * 43 + 42];
                    for (int c = b + 1; c < 41; c++)
                    {
                        if (comp == geneString[c + (a - 1) * 43 + 42])
                        if (comp == geneString[c + (b - 1) * 43 + 42])
                        for (int d = c + 1; d < 42; d++)
                        {
                            if (comp == geneString[d + (a - 1) * 43 + 42])
                            if (comp == geneString[d + (b - 1) * 43 + 42])
                            if (comp == geneString[d + (c - 1) * 43 + 42])
                            for (int e = d + 1; e < 43; e++)
                            {
                                if (comp == geneString[e + (a - 1) * 43 + 42])
                                if (comp == geneString[e + (b - 1) * 43 + 42])
                                if (comp == geneString[e + (c - 1) * 43 + 42])
                                if (comp == geneString[e + (d - 1) * 43 + 42])
                                Worth++;
                            }
                        }
                    }
                }
            }
            //if (Worth > 100) geneString = cheat();
            return Worth;
        }

    }
}