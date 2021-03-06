using System;

namespace Genetic_Algorithm_Template
{
    static public class GA_Mate_Helper
    {
        static internal string MutateGenes(string child, bool alwaysMutate, int odds)
        {
            Random rnd = new();
            if (alwaysMutate)
            {
                int geneToChange = rnd.Next(child.Length);
                char switchedGene = child[geneToChange] == '0' ? '1' : '0';
                if (geneToChange < child.Length)
                {
                    child = child[..geneToChange] + switchedGene + child[(geneToChange + 1)..];
                }
                else
                {
                    child = child[..geneToChange] + switchedGene;
                }
            }
            if (rnd.Next(odds) == 0) child = MutateGenes(child, true, odds);
            return child;
        }

        static internal string MateGenes(string mother, string father)
        {
            int halfway = mother.Length / 2;
            return mother[..halfway] + father[halfway..];
        }
    }
}