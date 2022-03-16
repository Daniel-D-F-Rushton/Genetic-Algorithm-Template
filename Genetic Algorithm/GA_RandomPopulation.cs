using System;

namespace Genetic_Algorithm_Template
{
    static public class GA_RandomPopulation
    {
        static internal void CreateRandomPopulation(this GeneticAlgorithm GA)
        {
            Random rnd = new();
            GA.Population.Clear();
            string randomGenes = "";
            for (int i = 0; i < GA.GeneticsSize; i++)
            {
                randomGenes += rnd.Next(2) == 0 ? '1' : '0';
            }
            while (GA.Population.Count < GA.PopulationSize)
            {
                GA.Population.Add(new Creature(randomGenes, 1000000000));
            }
        }
    }
}