using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm_Template
{
    public class R55Cheat: IProblem
    {    
        /// <summary>
        /// This is the same as the R55, except it makes a specific form of result based on only the top line of the
        /// adjacency matrix. It cascades the 1s, and 0s down to make a (sort of) symmetrical map. Using this it is easy
        /// to get the 43 counterproof attemt down to 42 errors - a feat that tends to take many weeks using the R55 alone.
        /// </summary>

        public int GeneSize { get; set; } = 1849;
        public int CalculateErrors(ref string geneString)
        {

            string holder = "";
            string spare = "000000000000000000000000000000000000000000000000000000000000000000";
            for (int i = 43; i > 0; i--)
            {
                holder += spare.Substring(0, 43 - i) + geneString.Substring(0, i);
            }
            geneString = holder;
            int Worth = 0;
            for (int a = 0; a < 39; a++)
            {
                for (int b = a + 1; b < 40; b++)
                {
                    char comp = geneString[b + (a - 1) * 43 + 42];
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
            //geneString = geneString.Substring(0, 43);
            return Worth;
        }

    }
}