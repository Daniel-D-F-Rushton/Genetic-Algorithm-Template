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
        /// 
        /// </summary>
        public int GeneSize { get; set; } = 903;
        public int CalculateErrors(string geneString)
        {

            int Worth = 0;
            for (int a = 0; a < 39 - 1; a++)
            {
                for (int b = a + 1; b < 40 - 1; b++)
                {
                    char comp = geneString[1 + a + (b * 43) - 43 - ((b * (b + 1)) / 2)];
                    for (int c = b + 1; c < 41 - 1; c++)
                    {
                        if (comp == geneString[1 + a + (c * 43) - 43 - ((c * (c + 1)) / 2)])
                        if (comp == geneString[1 + b + (c * 43) - 43 - ((c * (c + 1)) / 2)])
                        for (int d = c + 1; d < 42 - 1; d++)
                        {
                            if (comp == geneString[1 + a + (d * 43) - 43 - ((d * (d + 1)) / 2)])
                            if (comp == geneString[1 + b + (d * 43) - 43 - ((d * (d + 1)) / 2)])
                            if (comp == geneString[1 + c + (d * 43) - 43 - ((d * (d + 1)) / 2)])
                            for (int e = d + 1; e < 43 - 1; e++)
                            {
                                if (comp == geneString[1 + a + (e * 43) - 43 - ((e * (e + 1)) / 2)])
                                if (comp == geneString[1 + b + (e * 43) - 43 - ((e * (e + 1)) / 2)])
                                if (comp == geneString[1 + c + (e * 43) - 43 - ((e * (e + 1)) / 2)])
                                if (comp == geneString[1 + d + (e * 43) - 43 - ((e * (e + 1)) / 2)])
                                Worth++;
                            }
                        }
                    }
                }
            }
            return Worth;
        }

    }
}